using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesUpgradeSkillLevelCsReq : IMessage<PlanetFesUpgradeSkillLevelCsReq>, IMessage, IEquatable<PlanetFesUpgradeSkillLevelCsReq>, IDeepCloneable<PlanetFesUpgradeSkillLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesUpgradeSkillLevelCsReq> _parser = new MessageParser<PlanetFesUpgradeSkillLevelCsReq>(() => new PlanetFesUpgradeSkillLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ODADJILOEKOFieldNumber = 2;

	private uint oDADJILOEKO_;

	public const int SkillIdFieldNumber = 12;

	private uint skillId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesUpgradeSkillLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesUpgradeSkillLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeSkillLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeSkillLevelCsReq(PlanetFesUpgradeSkillLevelCsReq other)
		: this()
	{
		oDADJILOEKO_ = other.oDADJILOEKO_;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeSkillLevelCsReq Clone()
	{
		return new PlanetFesUpgradeSkillLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesUpgradeSkillLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesUpgradeSkillLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
		{
			return false;
		}
		if (SkillId != other.SkillId)
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
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
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
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ODADJILOEKO);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(SkillId);
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
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesUpgradeSkillLevelCsReq other)
	{
		if (other != null)
		{
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
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
			case 16u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			case 96u:
				SkillId = input.ReadUInt32();
				break;
			}
		}
	}
}
