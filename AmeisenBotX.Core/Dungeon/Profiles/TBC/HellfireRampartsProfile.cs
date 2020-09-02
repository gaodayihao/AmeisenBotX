﻿using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Dungeon.Enums;
using AmeisenBotX.Core.Dungeon.Objects;
using AmeisenBotX.Core.Jobs.Profiles;
using System.Collections.Generic;
using System.Numerics;

namespace AmeisenBotX.Core.Dungeon.Profiles.TBC
{
    public class HellfireRampartsProfile : IDungeonProfile
    {
        public string Author { get; } = "Jannis";

        public string Description { get; } = "Profile for the Dungeon in Outland, made for Level 58 to 62.";

        public DungeonFactionType FactionType { get; } = DungeonFactionType.Neutral;

        public int GroupSize { get; } = 5;

        public MapId MapId { get; } = MapId.HellfireRamparts;

        public int MaxLevel { get; } = 62;

        public string Name { get; } = "[58-62] Hellfire Ramparts";

        public List<DungeonNode> Nodes { get; private set; } = new List<DungeonNode>()
        {
            new DungeonNode(new Vector3(-1355, 1641, 68)),
            new DungeonNode(new Vector3(-1350, 1647, 69)),
            new DungeonNode(new Vector3(-1345, 1653, 69)),
            new DungeonNode(new Vector3(-1338, 1657, 69)),
            new DungeonNode(new Vector3(-1331, 1661, 69)),
            new DungeonNode(new Vector3(-1324, 1665, 68)),
            new DungeonNode(new Vector3(-1316, 1667, 67)),
            new DungeonNode(new Vector3(-1308, 1669, 66)),
            new DungeonNode(new Vector3(-1300, 1671, 66)),
            new DungeonNode(new Vector3(-1293, 1673, 68)),
            new DungeonNode(new Vector3(-1285, 1674, 69)),
            new DungeonNode(new Vector3(-1278, 1671, 69)),
            new DungeonNode(new Vector3(-1275, 1664, 69)),
            new DungeonNode(new Vector3(-1274, 1656, 69)),
            new DungeonNode(new Vector3(-1266, 1656, 69)),
            new DungeonNode(new Vector3(-1259, 1659, 68)),
            new DungeonNode(new Vector3(-1251, 1658, 67)),
            new DungeonNode(new Vector3(-1245, 1653, 67)),
            new DungeonNode(new Vector3(-1247, 1645, 68)),
            new DungeonNode(new Vector3(-1251, 1638, 68)),
            new DungeonNode(new Vector3(-1248, 1631, 69)),
            new DungeonNode(new Vector3(-1245, 1624, 69)),
            new DungeonNode(new Vector3(-1243, 1616, 69)),
            new DungeonNode(new Vector3(-1243, 1608, 69)),
            new DungeonNode(new Vector3(-1246, 1601, 69)),
            new DungeonNode(new Vector3(-1251, 1595, 69)),
            new DungeonNode(new Vector3(-1254, 1588, 69)),
            new DungeonNode(new Vector3(-1249, 1581, 69)),
            new DungeonNode(new Vector3(-1248, 1573, 68)),
            new DungeonNode(new Vector3(-1251, 1566, 69)),
            new DungeonNode(new Vector3(-1258, 1563, 69)),
            new DungeonNode(new Vector3(-1265, 1560, 69)),
            new DungeonNode(new Vector3(-1269, 1553, 69)),
            new DungeonNode(new Vector3(-1272, 1546, 69)),
            new DungeonNode(new Vector3(-1277, 1539, 69)),
            new DungeonNode(new Vector3(-1285, 1539, 69)),
            new DungeonNode(new Vector3(-1291, 1534, 69)),
            new DungeonNode(new Vector3(-1292, 1526, 69)),
            new DungeonNode(new Vector3(-1294, 1518, 69)),
            new DungeonNode(new Vector3(-1294, 1510, 69)),
            new DungeonNode(new Vector3(-1293, 1502, 69)),
            new DungeonNode(new Vector3(-1290, 1495, 69)),
            new DungeonNode(new Vector3(-1286, 1488, 69)),
            new DungeonNode(new Vector3(-1279, 1484, 69)),
            new DungeonNode(new Vector3(-1274, 1478, 69)),
            new DungeonNode(new Vector3(-1271, 1471, 69)),
            new DungeonNode(new Vector3(-1266, 1465, 69)),
            new DungeonNode(new Vector3(-1260, 1459, 69)),
            new DungeonNode(new Vector3(-1252, 1459, 69)),
            new DungeonNode(new Vector3(-1245, 1463, 69)),
            new DungeonNode(new Vector3(-1238, 1467, 69)),
            new DungeonNode(new Vector3(-1231, 1470, 69)),
            new DungeonNode(new Vector3(-1223, 1468, 69)),
            new DungeonNode(new Vector3(-1222, 1460, 69)),
            new DungeonNode(new Vector3(-1219, 1453, 69)),
            new DungeonNode(new Vector3(-1215, 1446, 69)),
            new DungeonNode(new Vector3(-1209, 1441, 69)),
            new DungeonNode(new Vector3(-1201, 1441, 69)),
            new DungeonNode(new Vector3(-1193, 1443, 68)),
            new DungeonNode(new Vector3(-1185, 1444, 68)),
            new DungeonNode(new Vector3(-1177, 1447, 68)),
            new DungeonNode(new Vector3(-1172, 1454, 68)),
            new DungeonNode(new Vector3(-1166, 1459, 68)),
            new DungeonNode(new Vector3(-1167, 1467, 68)),
            new DungeonNode(new Vector3(-1173, 1472, 68)),
            new DungeonNode(new Vector3(-1178, 1478, 68)),
            new DungeonNode(new Vector3(-1172, 1484, 68)),
            new DungeonNode(new Vector3(-1166, 1489, 68)),
            new DungeonNode(new Vector3(-1160, 1494, 68)),
            new DungeonNode(new Vector3(-1154, 1500, 68)),
            new DungeonNode(new Vector3(-1156, 1508, 68)),
            new DungeonNode(new Vector3(-1162, 1513, 68)),
            new DungeonNode(new Vector3(-1169, 1517, 68)),
            new DungeonNode(new Vector3(-1175, 1522, 68)),
            new DungeonNode(new Vector3(-1182, 1526, 68)),
            new DungeonNode(new Vector3(-1189, 1529, 69)),
            new DungeonNode(new Vector3(-1196, 1533, 69)),
            new DungeonNode(new Vector3(-1203, 1537, 69)),
            new DungeonNode(new Vector3(-1211, 1538, 69)),
            new DungeonNode(new Vector3(-1219, 1535, 69)),
            new DungeonNode(new Vector3(-1220, 1527, 69)),
            new DungeonNode(new Vector3(-1219, 1519, 69)),
            new DungeonNode(new Vector3(-1219, 1511, 69)),
            new DungeonNode(new Vector3(-1224, 1504, 71)),
            new DungeonNode(new Vector3(-1231, 1503, 74)),
            new DungeonNode(new Vector3(-1238, 1502, 77)),
            new DungeonNode(new Vector3(-1245, 1504, 80)),
            new DungeonNode(new Vector3(-1250, 1511, 82)),
            new DungeonNode(new Vector3(-1252, 1518, 85)),
            new DungeonNode(new Vector3(-1253, 1526, 88)),
            new DungeonNode(new Vector3(-1250, 1533, 89)),
            new DungeonNode(new Vector3(-1243, 1536, 90)),
            new DungeonNode(new Vector3(-1237, 1542, 90)),
            new DungeonNode(new Vector3(-1238, 1550, 91)),
            new DungeonNode(new Vector3(-1239, 1558, 91)),
            new DungeonNode(new Vector3(-1241, 1566, 91)),
            new DungeonNode(new Vector3(-1244, 1573, 91)),
            new DungeonNode(new Vector3(-1248, 1580, 91)),
            new DungeonNode(new Vector3(-1254, 1585, 91)),
            new DungeonNode(new Vector3(-1260, 1591, 92)),
            new DungeonNode(new Vector3(-1267, 1596, 92)),
            new DungeonNode(new Vector3(-1274, 1599, 92)),
            new DungeonNode(new Vector3(-1276, 1607, 92)),
            new DungeonNode(new Vector3(-1277, 1615, 92)),
            new DungeonNode(new Vector3(-1277, 1623, 92)),
            new DungeonNode(new Vector3(-1276, 1631, 92)),
            new DungeonNode(new Vector3(-1273, 1639, 92)),
            new DungeonNode(new Vector3(-1266, 1643, 92)),
            new DungeonNode(new Vector3(-1259, 1647, 93)),
            new DungeonNode(new Vector3(-1252, 1651, 93)),
            new DungeonNode(new Vector3(-1245, 1655, 93)),
            new DungeonNode(new Vector3(-1238, 1659, 93)),
            new DungeonNode(new Vector3(-1231, 1662, 92)),
            new DungeonNode(new Vector3(-1224, 1666, 93)),
            new DungeonNode(new Vector3(-1217, 1670, 93)),
            new DungeonNode(new Vector3(-1210, 1673, 93)),
            new DungeonNode(new Vector3(-1203, 1676, 93)),
            new DungeonNode(new Vector3(-1196, 1680, 92)),
            new DungeonNode(new Vector3(-1189, 1684, 91)),
            new DungeonNode(new Vector3(-1182, 1687, 91)),
            new DungeonNode(new Vector3(-1175, 1691, 91)),
            new DungeonNode(new Vector3(-1168, 1695, 92)),
            new DungeonNode(new Vector3(-1161, 1698, 91)),
            new DungeonNode(new Vector3(-1154, 1702, 91)),
            new DungeonNode(new Vector3(-1147, 1706, 91)),
            new DungeonNode(new Vector3(-1140, 1709, 90)),
            new DungeonNode(new Vector3(-1133, 1713, 90)),
            new DungeonNode(new Vector3(-1126, 1717, 89)),
            new DungeonNode(new Vector3(-1119, 1714, 90)),
            new DungeonNode(new Vector3(-1126, 1710, 90)),
            new DungeonNode(new Vector3(-1134, 1708, 90)),
            new DungeonNode(new Vector3(-1141, 1705, 90)),
            new DungeonNode(new Vector3(-1148, 1702, 91)),
            new DungeonNode(new Vector3(-1155, 1699, 91)),
            new DungeonNode(new Vector3(-1162, 1696, 91)),
            new DungeonNode(new Vector3(-1169, 1693, 92)),
            new DungeonNode(new Vector3(-1176, 1689, 91)),
            new DungeonNode(new Vector3(-1183, 1686, 91)),
            new DungeonNode(new Vector3(-1190, 1683, 91)),
            new DungeonNode(new Vector3(-1197, 1680, 92)),
            new DungeonNode(new Vector3(-1204, 1676, 93)),
            new DungeonNode(new Vector3(-1211, 1673, 93)),
            new DungeonNode(new Vector3(-1218, 1669, 93)),
            new DungeonNode(new Vector3(-1225, 1666, 93)),
            new DungeonNode(new Vector3(-1232, 1662, 92)),
            new DungeonNode(new Vector3(-1239, 1659, 93)),
            new DungeonNode(new Vector3(-1246, 1655, 93)),
            new DungeonNode(new Vector3(-1253, 1651, 93)),
            new DungeonNode(new Vector3(-1260, 1647, 93)),
            new DungeonNode(new Vector3(-1267, 1643, 92)),
            new DungeonNode(new Vector3(-1274, 1638, 92)),
            new DungeonNode(new Vector3(-1281, 1634, 92)),
            new DungeonNode(new Vector3(-1288, 1630, 92)),
            new DungeonNode(new Vector3(-1295, 1627, 92)),
            new DungeonNode(new Vector3(-1302, 1632, 92)),
            new DungeonNode(new Vector3(-1305, 1639, 92)),
            new DungeonNode(new Vector3(-1310, 1646, 92)),
            new DungeonNode(new Vector3(-1315, 1653, 92)),
            new DungeonNode(new Vector3(-1320, 1659, 92)),
            new DungeonNode(new Vector3(-1325, 1665, 93)),
            new DungeonNode(new Vector3(-1331, 1670, 93)),
            new DungeonNode(new Vector3(-1337, 1675, 92)),
            new DungeonNode(new Vector3(-1343, 1681, 91)),
            new DungeonNode(new Vector3(-1348, 1687, 89)),
            new DungeonNode(new Vector3(-1354, 1692, 88)),
            new DungeonNode(new Vector3(-1359, 1698, 86)),
            new DungeonNode(new Vector3(-1365, 1704, 84)),
            new DungeonNode(new Vector3(-1371, 1709, 83)),
            new DungeonNode(new Vector3(-1377, 1715, 83)),
            new DungeonNode(new Vector3(-1383, 1720, 83)),
            new DungeonNode(new Vector3(-1390, 1723, 82)),
            new DungeonNode(new Vector3(-1398, 1723, 82)),
            new DungeonNode(new Vector3(-1406, 1725, 82)),
            new DungeonNode(new Vector3(-1411, 1732, 81)),
            new DungeonNode(new Vector3(-1414, 1739, 81)),
            new DungeonNode(new Vector3(-1417, 1746, 81)),
            new DungeonNode(new Vector3(-1420, 1753, 81)),
            new DungeonNode(new Vector3(-1424, 1760, 82)),
            new DungeonNode(new Vector3(-1427, 1767, 82)),
            new DungeonNode(new Vector3(-1429, 1771, 82), DungeonNodeType.Use),
        };

        public List<string> PriorityUnits { get; } = new List<string>();

        public int RequiredItemLevel { get; } = 60;

        public int RequiredLevel { get; } = 58;

        public Vector3 WorldEntry { get; } = new Vector3(-362, 3078, -15);

        public MapId WorldEntryMapId { get; } = MapId.Outland;
    }
}