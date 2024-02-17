public class Program
{
	public static void Main()
	{
		var directories = new List<Directory>()
		{
			new ()
			{
				Name = "C",
				SubDirectories = new ()
				{
					new ()
					{
						Name = "Desktop",
						SubDirectories = new ()
						{
							new ()
							{
								Name = "NewDocument.docx"
							},
							new ()
							{
									Name = "NewTable.xlsx"
							},
							new ()
							{
									Name = "NewText.txt"
							}
      			}
					}
				}
			},
			new ()
			{
				Name = "D"
			}
		};

		var names = Solution.GetDirectoriesNames(directories);

		foreach (var name in names)
		{
			Console.WriteLine(name); // ["C", "Desktop", "NewDocument.docx", "NewTable.xlsx", "NewText.txt", "D"]
		}
	}
}

public class Solution
{
	private static readonly List<string> names = [];

	public static List<string> GetDirectoriesNames(List<Directory> data)
	{
		foreach (Directory directory in data)
		{
			names.Add(directory.Name);

			if (directory.SubDirectories.Count > 0)
			{
				GetDirectoriesNames(directory.SubDirectories);
			}
		}

		return names;
	}
}

public class Directory
{
	public string Name { get; init; } = string.Empty;
	public List<Directory> SubDirectories { get; init; } = [];
}