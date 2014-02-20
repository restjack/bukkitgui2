﻿namespace Bukkitgui2.MinecraftServers.Servers
{
    using System.Drawing;

    class BukkitServer : MinecraftServerBase
	{
        public override string Name
        {
            get { return "Bukkit"; }
        }

        public override string Site
        {
            get
            {
                return "http://bukkit.org";
            }
        }

        public override Image Logo
        {
            get { return Properties.Resources.bukkit_logo; }
        }

	}
}
