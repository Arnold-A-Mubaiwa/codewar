using System.Text.RegularExpressions;

namespace CodeWarsExercises.Rank_Up;

public static partial class Molecule
{
    public static Dictionary<string, int> ParseMolecule(string formula)
    {
        var atoms = SplitTheFormula().Split(formula);
        var newDic = new Dictionary<string, int>();
        var index = 0;
        
        foreach (var atom in atoms)
        {
            if (!MyRegex().IsMatch(atom))
            {
                newDic.TryAdd(atom, 1);
                if (index == atoms.Length - 1) continue;

                for (var current = index + 1; current < atoms.Length; current++)
                {
                    if (index!=1)
                        if (int.TryParse(atoms[current], out var outV))
                            newDic[atom] *= outV;
                        else
                            break;
                }
                index++;
            }
            else
            {
                index++;
            }
        }
        return newDic;
    }

    [GeneratedRegex(@"(?=[A-Z1-9\W])")]
    private static partial Regex SplitTheFormula();
    [GeneratedRegex(@"(?<=[a-zA-Z])[\d\W]")]
    private static partial Regex MyRegex();
}