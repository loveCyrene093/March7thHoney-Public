using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCCMGOOPHBO : IMessage<JCCMGOOPHBO>, IMessage, IEquatable<JCCMGOOPHBO>, IDeepCloneable<JCCMGOOPHBO>, IBufferMessage
{
	private static readonly MessageParser<JCCMGOOPHBO> _parser = new MessageParser<JCCMGOOPHBO>(() => new JCCMGOOPHBO());

	private UnknownFieldSet _unknownFields;

	public const int HDGHCOJICEGFieldNumber = 1;

	private uint hDGHCOJICEG_;

	public const int MapIdFieldNumber = 6;

	private uint mapId_;

	public const int MLPGGIPCNGFFieldNumber = 10;

	private uint mLPGGIPCNGF_;

	public const int JLELBCFOBKNFieldNumber = 11;

	private uint jLELBCFOBKN_;

	public const int DEKNGNHLFNIFieldNumber = 12;

	private uint dEKNGNHLFNI_;

	public const int MaxScoreFieldNumber = 13;

	private uint maxScore_;

	public const int RewardFieldNumber = 14;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCCMGOOPHBO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCCMGOOPHBOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HDGHCOJICEG
	{
		get
		{
			return hDGHCOJICEG_;
		}
		set
		{
			hDGHCOJICEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLPGGIPCNGF
	{
		get
		{
			return mLPGGIPCNGF_;
		}
		set
		{
			mLPGGIPCNGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JLELBCFOBKN
	{
		get
		{
			return jLELBCFOBKN_;
		}
		set
		{
			jLELBCFOBKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEKNGNHLFNI
	{
		get
		{
			return dEKNGNHLFNI_;
		}
		set
		{
			dEKNGNHLFNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCCMGOOPHBO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCCMGOOPHBO(JCCMGOOPHBO other)
		: this()
	{
		hDGHCOJICEG_ = other.hDGHCOJICEG_;
		mapId_ = other.mapId_;
		mLPGGIPCNGF_ = other.mLPGGIPCNGF_;
		jLELBCFOBKN_ = other.jLELBCFOBKN_;
		dEKNGNHLFNI_ = other.dEKNGNHLFNI_;
		maxScore_ = other.maxScore_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCCMGOOPHBO Clone()
	{
		return new JCCMGOOPHBO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCCMGOOPHBO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCCMGOOPHBO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HDGHCOJICEG != other.HDGHCOJICEG)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (MLPGGIPCNGF != other.MLPGGIPCNGF)
		{
			return false;
		}
		if (JLELBCFOBKN != other.JLELBCFOBKN)
		{
			return false;
		}
		if (DEKNGNHLFNI != other.DEKNGNHLFNI)
		{
			return false;
		}
		if (MaxScore != other.MaxScore)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (HDGHCOJICEG != 0)
		{
			num ^= HDGHCOJICEG.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (MLPGGIPCNGF != 0)
		{
			num ^= MLPGGIPCNGF.GetHashCode();
		}
		if (JLELBCFOBKN != 0)
		{
			num ^= JLELBCFOBKN.GetHashCode();
		}
		if (DEKNGNHLFNI != 0)
		{
			num ^= DEKNGNHLFNI.GetHashCode();
		}
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (HDGHCOJICEG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HDGHCOJICEG);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MapId);
		}
		if (MLPGGIPCNGF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MLPGGIPCNGF);
		}
		if (JLELBCFOBKN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JLELBCFOBKN);
		}
		if (DEKNGNHLFNI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DEKNGNHLFNI);
		}
		if (MaxScore != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MaxScore);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Reward);
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
		if (HDGHCOJICEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HDGHCOJICEG);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (MLPGGIPCNGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLPGGIPCNGF);
		}
		if (JLELBCFOBKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLELBCFOBKN);
		}
		if (DEKNGNHLFNI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEKNGNHLFNI);
		}
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCCMGOOPHBO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HDGHCOJICEG != 0)
		{
			HDGHCOJICEG = other.HDGHCOJICEG;
		}
		if (other.MapId != 0)
		{
			MapId = other.MapId;
		}
		if (other.MLPGGIPCNGF != 0)
		{
			MLPGGIPCNGF = other.MLPGGIPCNGF;
		}
		if (other.JLELBCFOBKN != 0)
		{
			JLELBCFOBKN = other.JLELBCFOBKN;
		}
		if (other.DEKNGNHLFNI != 0)
		{
			DEKNGNHLFNI = other.DEKNGNHLFNI;
		}
		if (other.MaxScore != 0)
		{
			MaxScore = other.MaxScore;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
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
			case 8u:
				HDGHCOJICEG = input.ReadUInt32();
				break;
			case 48u:
				MapId = input.ReadUInt32();
				break;
			case 80u:
				MLPGGIPCNGF = input.ReadUInt32();
				break;
			case 88u:
				JLELBCFOBKN = input.ReadUInt32();
				break;
			case 96u:
				DEKNGNHLFNI = input.ReadUInt32();
				break;
			case 104u:
				MaxScore = input.ReadUInt32();
				break;
			case 114u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
