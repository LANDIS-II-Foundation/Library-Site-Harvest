﻿using System.Reflection;

[assembly: AssemblyTitle("Harvest Library")]
[assembly: AssemblyVersion("0.3.*")]
[assembly: AssemblyDescription("Harvest Library for LANDIS-II")]
[assembly: AssemblyCopyright("2014 University of Notre Dame")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif