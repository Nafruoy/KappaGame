﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kappa.server.packet;

namespace Kappa.server.connection {
    class OfflinePlayerConnection : PlayerConnection {

        public OfflinePlayerConnection() {
            Type = ConnectionType.OFFLINE;
        }

    }
}
