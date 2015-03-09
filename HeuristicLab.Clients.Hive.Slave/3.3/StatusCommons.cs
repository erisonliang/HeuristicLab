﻿#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2015 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
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
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HeuristicLab.Clients.Hive.SlaveCore {
  /// <summary>
  /// Various Status Information for the ClientConsole
  /// </summary>
  [DataContract]
  public class StatusCommons {
    [DataMember]
    public Guid ClientGuid { get; set; }
    [DataMember]
    public NetworkEnum.WcfConnState Status { get; set; }
    [DataMember]
    public DateTime ConnectedSince { get; set; }
    [DataMember]
    public int TotalCores { get; set; }
    [DataMember]
    public int FreeCores { get; set; }
    [DataMember]
    public int JobsFetched { get; set; }
    [DataMember]
    public int JobsStarted { get; set; }
    [DataMember]
    public int JobsFinished { get; set; }
    [DataMember]
    public int JobsAborted { get; set; }
    [DataMember]
    public int JobsFailed { get; set; }
    [DataMember]
    public List<TaskStatus> Jobs { get; set; }
    [DataMember]
    public bool Asleep { get; set; }

    public override string ToString() {
      return string.Format("Status: {0}, Fetc,Start,Fin,Abor,Fail,Exc: {1},{2},{3},{4},{5}",
        Status, JobsFetched, JobsStarted, JobsFinished, JobsAborted, JobsFailed);
    }
  }
}
