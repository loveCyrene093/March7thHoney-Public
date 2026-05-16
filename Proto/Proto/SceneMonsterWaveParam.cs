using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneMonsterWaveParam : IMessage<SceneMonsterWaveParam>, IMessage, IEquatable<SceneMonsterWaveParam>, IDeepCloneable<SceneMonsterWaveParam>, IBufferMessage
{
	private static readonly MessageParser<SceneMonsterWaveParam> _parser = new MessageParser<SceneMonsterWaveParam>(() => new SceneMonsterWaveParam());

	private UnknownFieldSet _unknownFields;

	public const int HardLevelGroupFieldNumber = 5;

	private uint hardLevelGroup_;

	public const int BDCCEFHMFHOFieldNumber = 7;

	private uint bDCCEFHMFHO_;

	public const int EliteGroupFieldNumber = 10;

	private uint eliteGroup_;

	public const int LevelFieldNumber = 14;

	private uint level_;

	public const int OPJAFNEFJDCFieldNumber = 15;

	private uint oPJAFNEFJDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneMonsterWaveParam> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneMonsterWaveParamReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HardLevelGroup
	{
		get
		{
			return hardLevelGroup_;
		}
		set
		{
			hardLevelGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDCCEFHMFHO
	{
		get
		{
			return bDCCEFHMFHO_;
		}
		set
		{
			bDCCEFHMFHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EliteGroup
	{
		get
		{
			return eliteGroup_;
		}
		set
		{
			eliteGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPJAFNEFJDC
	{
		get
		{
			return oPJAFNEFJDC_;
		}
		set
		{
			oPJAFNEFJDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWaveParam()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWaveParam(SceneMonsterWaveParam other)
		: this()
	{
		hardLevelGroup_ = other.hardLevelGroup_;
		bDCCEFHMFHO_ = other.bDCCEFHMFHO_;
		eliteGroup_ = other.eliteGroup_;
		level_ = other.level_;
		oPJAFNEFJDC_ = other.oPJAFNEFJDC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWaveParam Clone()
	{
		return new SceneMonsterWaveParam(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneMonsterWaveParam);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneMonsterWaveParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HardLevelGroup != other.HardLevelGroup)
		{
			return false;
		}
		if (BDCCEFHMFHO != other.BDCCEFHMFHO)
		{
			return false;
		}
		if (EliteGroup != other.EliteGroup)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (OPJAFNEFJDC != other.OPJAFNEFJDC)
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
		if (HardLevelGroup != 0)
		{
			num ^= HardLevelGroup.GetHashCode();
		}
		if (BDCCEFHMFHO != 0)
		{
			num ^= BDCCEFHMFHO.GetHashCode();
		}
		if (EliteGroup != 0)
		{
			num ^= EliteGroup.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (OPJAFNEFJDC != 0)
		{
			num ^= OPJAFNEFJDC.GetHashCode();
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
		if (HardLevelGroup != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HardLevelGroup);
		}
		if (BDCCEFHMFHO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BDCCEFHMFHO);
		}
		if (EliteGroup != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EliteGroup);
		}
		if (Level != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Level);
		}
		if (OPJAFNEFJDC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OPJAFNEFJDC);
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
		if (HardLevelGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HardLevelGroup);
		}
		if (BDCCEFHMFHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDCCEFHMFHO);
		}
		if (EliteGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EliteGroup);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (OPJAFNEFJDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPJAFNEFJDC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneMonsterWaveParam other)
	{
		if (other != null)
		{
			if (other.HardLevelGroup != 0)
			{
				HardLevelGroup = other.HardLevelGroup;
			}
			if (other.BDCCEFHMFHO != 0)
			{
				BDCCEFHMFHO = other.BDCCEFHMFHO;
			}
			if (other.EliteGroup != 0)
			{
				EliteGroup = other.EliteGroup;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.OPJAFNEFJDC != 0)
			{
				OPJAFNEFJDC = other.OPJAFNEFJDC;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 40u:
				HardLevelGroup = input.ReadUInt32();
				break;
			case 56u:
				BDCCEFHMFHO = input.ReadUInt32();
				break;
			case 80u:
				EliteGroup = input.ReadUInt32();
				break;
			case 112u:
				Level = input.ReadUInt32();
				break;
			case 120u:
				OPJAFNEFJDC = input.ReadUInt32();
				break;
			}
		}
	}
}
