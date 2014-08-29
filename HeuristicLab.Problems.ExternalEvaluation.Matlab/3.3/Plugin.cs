#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2014 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

using System;
using HeuristicLab.PluginInfrastructure;
using Microsoft.Win32;

namespace HeuristicLab.Problems.ExternalEvaluation.Matlab {
  /// <summary>
  /// Plugin class for HeuristicLab.Problems.ExternalEvaluation.Matlab plugin.
  /// </summary>
  [Plugin("HeuristicLab.Problems.ExternalEvaluation.MATLAB", "3.3.10.11173")]
  [PluginFile("HeuristicLab.Problems.ExternalEvaluation.Matlab-3.3.dll", PluginFileType.Assembly)]
  [PluginDependency("HeuristicLab.Collections", "3.3")]
  [PluginDependency("HeuristicLab.Common", "3.3")]
  [PluginDependency("HeuristicLab.Core", "3.3")]
  [PluginDependency("HeuristicLab.Data", "3.3")]
  [PluginDependency("HeuristicLab.Encodings.RealVectorEncoding", "3.3")]
  [PluginDependency("HeuristicLab.MatlabConnector", "1.0")]
  [PluginDependency("HeuristicLab.Operators", "3.3")]
  [PluginDependency("HeuristicLab.Parameters", "3.3")]
  [PluginDependency("HeuristicLab.Persistence", "3.3")]
  [PluginDependency("HeuristicLab.Problems.ParameterOptimization", "3.3")]
  public class HeuristicLabProblemsExternalEvaluationMatlabPlugin : PluginBase {  }
}
