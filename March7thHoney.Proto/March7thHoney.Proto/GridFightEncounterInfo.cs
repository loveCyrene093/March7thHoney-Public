using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEncounterInfo : IMessage<GridFightEncounterInfo>, IMessage, IEquatable<GridFightEncounterInfo>, IDeepCloneable<GridFightEncounterInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightEncounterInfo> _parser = new MessageParser<GridFightEncounterInfo>(() => new GridFightEncounterInfo());

	private UnknownFieldSet _unknownFields;

	public const int LFKBMDHKPFIFieldNumber = 8;

	private uint lFKBMDHKPFI_;

	public const int GDOEOGMJDAOFieldNumber = 11;

	private uint gDOEOGMJDAO_;

	public const int MonsterWaveListFieldNumber = 13;

	private static readonly FieldCodec<GridEncounterMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage(106u, GridEncounterMonsterWave.Parser);

	private readonly RepeatedField<GridEncounterMonsterWave> monsterWaveList_ = new RepeatedField<GridEncounterMonsterWave>();

	public const int BAGCBHFJIMNFieldNumber = 14;

	private uint bAGCBHFJIMN_;

	public const int LMLAOPMDCCAFieldNumber = 15;

	private GridFightDropInfo lMLAOPMDCCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEncounterInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEncounterInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFKBMDHKPFI
	{
		get
		{
			return lFKBMDHKPFI_;
		}
		set
		{
			lFKBMDHKPFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDOEOGMJDAO
	{
		get
		{
			return gDOEOGMJDAO_;
		}
		set
		{
			gDOEOGMJDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridEncounterMonsterWave> MonsterWaveList => monsterWaveList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BAGCBHFJIMN
	{
		get
		{
			return bAGCBHFJIMN_;
		}
		set
		{
			bAGCBHFJIMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropInfo LMLAOPMDCCA
	{
		get
		{
			return lMLAOPMDCCA_;
		}
		set
		{
			lMLAOPMDCCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEncounterInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEncounterInfo(GridFightEncounterInfo other)
		: this()
	{
		lFKBMDHKPFI_ = other.lFKBMDHKPFI_;
		gDOEOGMJDAO_ = other.gDOEOGMJDAO_;
		monsterWaveList_ = other.monsterWaveList_.Clone();
		bAGCBHFJIMN_ = other.bAGCBHFJIMN_;
		lMLAOPMDCCA_ = ((other.lMLAOPMDCCA_ != null) ? other.lMLAOPMDCCA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEncounterInfo Clone()
	{
		return new GridFightEncounterInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEncounterInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEncounterInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LFKBMDHKPFI != other.LFKBMDHKPFI)
		{
			return false;
		}
		if (GDOEOGMJDAO != other.GDOEOGMJDAO)
		{
			return false;
		}
		if (!monsterWaveList_.Equals(other.monsterWaveList_))
		{
			return false;
		}
		if (BAGCBHFJIMN != other.BAGCBHFJIMN)
		{
			return false;
		}
		if (!object.Equals(LMLAOPMDCCA, other.LMLAOPMDCCA))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (LFKBMDHKPFI != 0)
		{
			num ^= LFKBMDHKPFI.GetHashCode();
		}
		if (GDOEOGMJDAO != 0)
		{
			num ^= GDOEOGMJDAO.GetHashCode();
		}
		num ^= monsterWaveList_.GetHashCode();
		if (BAGCBHFJIMN != 0)
		{
			num ^= BAGCBHFJIMN.GetHashCode();
		}
		if (lMLAOPMDCCA_ != null)
		{
			num ^= LMLAOPMDCCA.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (LFKBMDHKPFI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LFKBMDHKPFI);
		}
		if (GDOEOGMJDAO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GDOEOGMJDAO);
		}
		monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
		if (BAGCBHFJIMN != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BAGCBHFJIMN);
		}
		if (lMLAOPMDCCA_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(LMLAOPMDCCA);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (LFKBMDHKPFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFKBMDHKPFI);
		}
		if (GDOEOGMJDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDOEOGMJDAO);
		}
		num += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
		if (BAGCBHFJIMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BAGCBHFJIMN);
		}
		if (lMLAOPMDCCA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LMLAOPMDCCA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEncounterInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LFKBMDHKPFI != 0)
		{
			LFKBMDHKPFI = other.LFKBMDHKPFI;
		}
		if (other.GDOEOGMJDAO != 0)
		{
			GDOEOGMJDAO = other.GDOEOGMJDAO;
		}
		monsterWaveList_.Add(other.monsterWaveList_);
		if (other.BAGCBHFJIMN != 0)
		{
			BAGCBHFJIMN = other.BAGCBHFJIMN;
		}
		if (other.lMLAOPMDCCA_ != null)
		{
			if (lMLAOPMDCCA_ == null)
			{
				LMLAOPMDCCA = new GridFightDropInfo();
			}
			LMLAOPMDCCA.MergeFrom(other.LMLAOPMDCCA);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 64u:
				LFKBMDHKPFI = input.ReadUInt32();
				break;
			case 88u:
				GDOEOGMJDAO = input.ReadUInt32();
				break;
			case 106u:
				monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
				break;
			case 112u:
				BAGCBHFJIMN = input.ReadUInt32();
				break;
			case 122u:
				if (lMLAOPMDCCA_ == null)
				{
					LMLAOPMDCCA = new GridFightDropInfo();
				}
				input.ReadMessage(LMLAOPMDCCA);
				break;
			}
		}
	}
}
