using System;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class ClassModel {

    public ClassModel(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
