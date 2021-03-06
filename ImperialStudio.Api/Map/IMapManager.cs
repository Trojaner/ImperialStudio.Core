﻿namespace ImperialStudio.Api.Map
{
    public interface IMapManager
    {
        string CurrentMap { get; }

        void ChangeMap(string mapName);

        void GoToMainMenu();
    }
}