﻿namespace AltV.Icarus.Commands.Interfaces;

public interface ICommandData
{
    public string Name { get; set; }
    public string[ ] Aliases { get; set; }
    public string Description { get; set; }
    public uint RequiredLevel { get; set; }
}