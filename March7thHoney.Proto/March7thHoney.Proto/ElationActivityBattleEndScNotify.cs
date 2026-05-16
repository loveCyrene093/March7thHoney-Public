using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElationActivityBattleEndScNotify : IMessage<ElationActivityBattleEndScNotify>, IMessage, IEquatable<ElationActivityBattleEndScNotify>, IDeepCloneable<ElationActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<ElationActivityBattleEndScNotify> _parser = new MessageParser<ElationActivityBattleEndScNotify>(() => new ElationActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GGCPDPFMAEGFieldNumber = 1;

	private uint gGCPDPFMAEG_;

	public const int PerfectWaveFieldNumber = 6;

	private uint perfectWave_;

	public const int LevelDataFieldNumber = 10;

	private ElationActivityLevelData levelData_;

	public const int HJAADAOGAMPFieldNumber = 12;

	private uint hJAADAOGAMP_;

	public const int LevelIdFieldNumber = 15;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElationActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElationActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGCPDPFMAEG
	{
		get
		{
			return gGCPDPFMAEG_;
		}
		set
		{
			gGCPDPFMAEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerfectWave
	{
		get
		{
			return perfectWave_;
		}
		set
		{
			perfectWave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityLevelData LevelData
	{
		get
		{
			return levelData_;
		}
		set
		{
			levelData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJAADAOGAMP
	{
		get
		{
			return hJAADAOGAMP_;
		}
		set
		{
			hJAADAOGAMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityBattleEndScNotify(ElationActivityBattleEndScNotify other)
		: this()
	{
		gGCPDPFMAEG_ = other.gGCPDPFMAEG_;
		perfectWave_ = other.perfectWave_;
		levelData_ = ((other.levelData_ != null) ? other.levelData_.Clone() : null);
		hJAADAOGAMP_ = other.hJAADAOGAMP_;
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityBattleEndScNotify Clone()
	{
		return new ElationActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElationActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElationActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GGCPDPFMAEG != other.GGCPDPFMAEG)
		{
			return false;
		}
		if (PerfectWave != other.PerfectWave)
		{
			return false;
		}
		if (!object.Equals(LevelData, other.LevelData))
		{
			return false;
		}
		if (HJAADAOGAMP != other.HJAADAOGAMP)
		{
			return false;
		}
		if (LevelId != other.LevelId)
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
		if (GGCPDPFMAEG != 0)
		{
			num ^= GGCPDPFMAEG.GetHashCode();
		}
		if (PerfectWave != 0)
		{
			num ^= PerfectWave.GetHashCode();
		}
		if (levelData_ != null)
		{
			num ^= LevelData.GetHashCode();
		}
		if (HJAADAOGAMP != 0)
		{
			num ^= HJAADAOGAMP.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
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
		if (GGCPDPFMAEG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GGCPDPFMAEG);
		}
		if (PerfectWave != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PerfectWave);
		}
		if (levelData_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LevelData);
		}
		if (HJAADAOGAMP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HJAADAOGAMP);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LevelId);
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
		if (GGCPDPFMAEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGCPDPFMAEG);
		}
		if (PerfectWave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerfectWave);
		}
		if (levelData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LevelData);
		}
		if (HJAADAOGAMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJAADAOGAMP);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElationActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GGCPDPFMAEG != 0)
		{
			GGCPDPFMAEG = other.GGCPDPFMAEG;
		}
		if (other.PerfectWave != 0)
		{
			PerfectWave = other.PerfectWave;
		}
		if (other.levelData_ != null)
		{
			if (levelData_ == null)
			{
				LevelData = new ElationActivityLevelData();
			}
			LevelData.MergeFrom(other.LevelData);
		}
		if (other.HJAADAOGAMP != 0)
		{
			HJAADAOGAMP = other.HJAADAOGAMP;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
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
				GGCPDPFMAEG = input.ReadUInt32();
				break;
			case 48u:
				PerfectWave = input.ReadUInt32();
				break;
			case 82u:
				if (levelData_ == null)
				{
					LevelData = new ElationActivityLevelData();
				}
				input.ReadMessage(LevelData);
				break;
			case 96u:
				HJAADAOGAMP = input.ReadUInt32();
				break;
			case 120u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
