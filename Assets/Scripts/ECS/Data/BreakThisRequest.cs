using System;
using Scellecs.Morpeh;
using Scellecs.Morpeh.Systems;

public struct BreakThisRequest : IRequestData
{
    public Entity targetEntity;
    public bool breakCompletely;
}