using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum SyncLineupReason
{
	[OriginalName("SYNC_REASON_NONE")]
	SyncReasonNone,
	[OriginalName("SYNC_REASON_MP_ADD")]
	SyncReasonMpAdd,
	[OriginalName("SYNC_REASON_MP_ADD_PROP_HIT")]
	SyncReasonMpAddPropHit,
	[OriginalName("SYNC_REASON_HP_ADD")]
	SyncReasonHpAdd,
	[OriginalName("SYNC_REASON_HP_ADD_PROP_HIT")]
	SyncReasonHpAddPropHit,
	[OriginalName("SYNC_REASON_MP_MAX_CHANGED_PERMANENT")]
	SyncReasonMpMaxChangedPermanent,
	[OriginalName("SYNC_REASON_MP_MAX_CHANGED_BY_MODIFIER")]
	SyncReasonMpMaxChangedByModifier
}
