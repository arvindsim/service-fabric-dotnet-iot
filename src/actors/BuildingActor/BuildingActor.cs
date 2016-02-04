﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace BuildingActor
{
    using System.Threading.Tasks;
    using IoTActor.Common;
    using Microsoft.ServiceFabric.Actors;

    public class BuildingActor : StatefulActor<BuildingActorState>, IIoTActor
    {
        [Readonly] // currently building actor does not maintain state
        public Task Post(string DeviceId, string EventHubName, string ServiceBusNS, byte[] Body)
        {
            /*
            The following are the chain in this samples
            Device->Floor->Building

            You can tailor the aggregators even further. for example
            Device->Floor->Building->Campus

            A building actor in this sample represents end of the chain, you can use it
            to respond to events at the building level (including all floors each contains devices). 

            Note: aggregators should not store events, since raw events are stored
                  at the device level using Storage Actor. You can choose to store other 
                  data such as commands generated by building actor.. 
            */

            return Task.FromResult(0);
        }
    }
}