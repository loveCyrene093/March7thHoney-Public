using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Activity.Activities.DiceCombat;

internal static class DiceCombatConfig
{
	private static readonly (uint AvatarId, uint Level, long UnlockTime, uint D1, uint D2, uint D3, uint D4)[] AvatarSeedData = new(uint, uint, long, uint, uint, uint, uint)[36]
	{
		(264000u, 2u, 1770976278281L, 264101u, 264201u, 264301u, 0u),
		(264001u, 2u, 1770976496907L, 264101u, 264201u, 0u, 0u),
		(264002u, 2u, 1771055499911L, 264101u, 264201u, 0u, 0u),
		(264003u, 2u, 1771055504051L, 264101u, 0u, 0u, 0u),
		(264004u, 2u, 1771148195045L, 264101u, 264201u, 0u, 0u),
		(264005u, 2u, 1771148199125L, 264101u, 264201u, 0u, 0u),
		(264006u, 2u, 1771055522532L, 264101u, 264201u, 264301u, 0u),
		(264007u, 2u, 1771055507742L, 264101u, 264201u, 0u, 0u),
		(264008u, 2u, 1771055511035L, 264101u, 264201u, 0u, 0u),
		(264009u, 2u, 1771055518499L, 264101u, 264201u, 0u, 0u),
		(264010u, 2u, 1771055514769L, 264101u, 264201u, 264301u, 0u),
		(264011u, 2u, 1770986589206L, 264101u, 264201u, 264301u, 0u),
		(264012u, 3u, 1771049954159L, 264101u, 264201u, 264301u, 264406u),
		(264013u, 3u, 1771046177326L, 264101u, 264201u, 264301u, 264508u),
		(264014u, 3u, 1771044602165L, 264101u, 264201u, 0u, 264418u),
		(264015u, 3u, 1771047032591L, 264101u, 264201u, 0u, 0u),
		(264016u, 3u, 1771046734029L, 0u, 264201u, 264301u, 264404u),
		(264017u, 3u, 1771055529322L, 264101u, 264201u, 0u, 264516u),
		(264018u, 3u, 1771142713930L, 264101u, 264201u, 264301u, 264516u),
		(264019u, 3u, 1771047898454L, 264101u, 264201u, 0u, 264422u),
		(264020u, 3u, 1771050289990L, 0u, 264201u, 264301u, 264518u),
		(264021u, 3u, 1771047370882L, 264101u, 264201u, 264301u, 264518u),
		(264022u, 3u, 1771050658641L, 0u, 264201u, 264301u, 264504u),
		(264023u, 3u, 1771050985889L, 264101u, 264201u, 264301u, 264421u),
		(264024u, 3u, 1771048033745L, 0u, 264201u, 264301u, 264407u),
		(264025u, 3u, 1771046332675L, 0u, 264201u, 264301u, 264413u),
		(264026u, 1u, 1777461579416L, 0u, 264201u, 0u, 264519u),
		(264027u, 1u, 1777461583527L, 264101u, 264201u, 264301u, 264523u),
		(264028u, 1u, 1777460949357L, 0u, 264201u, 0u, 264519u),
		(264029u, 1u, 1777459237376L, 264101u, 264201u, 264301u, 264506u),
		(264030u, 1u, 1777460227601L, 264101u, 264201u, 0u, 264509u),
		(264031u, 1u, 1777461639890L, 0u, 264201u, 264301u, 264507u),
		(264032u, 1u, 1777459759637L, 264101u, 264201u, 0u, 264524u),
		(264033u, 1u, 1777461643334L, 0u, 264201u, 264301u, 264522u),
		(264034u, 1u, 1777458716236L, 0u, 264201u, 264301u, 264512u),
		(264035u, 1u, 1777467364167L, 264101u, 264201u, 264301u, 264508u)
	};

	private static readonly (uint StageId, long UnlockTimestamp)[] StageSeedData = new(uint, long)[25]
	{
		(264402u, 1771051069416L),
		(264403u, 1771147284277L),
		(264404u, 1771149683526L),
		(264405u, 1771055534841L),
		(264406u, 1771049965440L),
		(264407u, 1771055543220L),
		(264408u, 1771051073524L),
		(264409u, 1771055552219L),
		(264410u, 1771055556012L),
		(264411u, 1771055539244L),
		(264412u, 1771048043204L),
		(264413u, 1771048295676L),
		(264416u, 1771150779651L),
		(264417u, 1771055560009L),
		(264418u, 1771046714669L),
		(264419u, 1771055548148L),
		(264420u, 1771047522482L),
		(264421u, 1771051020887L),
		(264422u, 1771047905782L),
		(264423u, 1777461587625L),
		(264424u, 1777461590867L),
		(264425u, 1777461594272L),
		(264426u, 1777461600425L),
		(264427u, 1777461632302L),
		(264428u, 1777461635606L)
	};

	public static GetSystemDataRsp BuildOfficialCompletedSnapshot()
	{
		GetSystemDataRsp getSystemDataRsp = new GetSystemDataRsp();
		getSystemDataRsp.FKOBFPNGDCG.AddRange(new _003C_003Ez__ReadOnlyArray<uint>(new uint[39]
		{
			1001u, 1002u, 2009u, 2011u, 2020u, 2024u, 2025u, 2027u, 2028u, 2039u,
			2043u, 2044u, 2045u, 2046u, 2047u, 2048u, 2050u, 2051u, 2052u, 2054u,
			2055u, 2056u, 2060u, 2102u, 2103u, 2104u, 2105u, 9000u, 9001u, 9002u,
			9003u, 9004u, 9005u, 9007u, 9008u, 9009u, 9010u, 9011u, 9200u
		}));
		(uint, uint, long, uint, uint, uint, uint)[] avatarSeedData = AvatarSeedData;
		for (int i = 0; i < avatarSeedData.Length; i++)
		{
			var (diceAvatarId, level, unlockTime, item, item2, item3, item4) = avatarSeedData[i];
			getSystemDataRsp.AvatarList.Add(new DiceCombatAvatar
			{
				DiceAvatarId = diceAvatarId,
				Level = level,
				UnlockTime = unlockTime,
				DiceIdList = { item, item2, item3, item4 }
			});
		}
		(uint, long)[] stageSeedData = StageSeedData;
		for (int i = 0; i < stageSeedData.Length; i++)
		{
			var (fLEOCMEFANH, unlockTimestamp) = stageSeedData[i];
			getSystemDataRsp.FAMFCIPLGON.Add(new INACEGAAALJ
			{
				FLEOCMEFANH = fLEOCMEFANH,
				UnlockTimestamp = unlockTimestamp
			});
		}
		getSystemDataRsp.DKCGALDKDFA = new DABNCEPBKMG();
		getSystemDataRsp.DKCGALDKDFA.IOJMFDDPBHI.AddRange(new _003C_003Ez__ReadOnlyArray<uint>(new uint[6] { 1001u, 1002u, 1003u, 1004u, 1005u, 1006u }));
		getSystemDataRsp.DKCGALDKDFA.JFEKKNNHCOH.Add(new MDFEFKDEFML
		{
			StageId = 2001u,
			BPNBNPGPFJK = 8100u
		});
		getSystemDataRsp.DKCGALDKDFA.JFEKKNNHCOH.Add(new MDFEFKDEFML
		{
			StageId = 2002u,
			BPNBNPGPFJK = 7600u
		});
		getSystemDataRsp.DKCGALDKDFA.JFEKKNNHCOH.Add(new MDFEFKDEFML
		{
			StageId = 2003u,
			BPNBNPGPFJK = 8500u
		});
		return getSystemDataRsp;
	}
}
