using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDealAvatarEventOptionItemCsReq : IMessage<PlanetFesDealAvatarEventOptionItemCsReq>, IMessage, IEquatable<PlanetFesDealAvatarEventOptionItemCsReq>, IDeepCloneable<PlanetFesDealAvatarEventOptionItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesDealAvatarEventOptionItemCsReq> _parser = new MessageParser<PlanetFesDealAvatarEventOptionItemCsReq>(() => new PlanetFesDealAvatarEventOptionItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ICOGAHFFCLDFieldNumber = 2;

	private bool iCOGAHFFCLD_;

	public const int GLIONEELOJHFieldNumber = 4;

	private uint gLIONEELOJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDealAvatarEventOptionItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDealAvatarEventOptionItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICOGAHFFCLD
	{
		get
		{
			return iCOGAHFFCLD_;
		}
		set
		{
			iCOGAHFFCLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLIONEELOJH
	{
		get
		{
			return gLIONEELOJH_;
		}
		set
		{
			gLIONEELOJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDealAvatarEventOptionItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDealAvatarEventOptionItemCsReq(PlanetFesDealAvatarEventOptionItemCsReq other)
		: this()
	{
		iCOGAHFFCLD_ = other.iCOGAHFFCLD_;
		gLIONEELOJH_ = other.gLIONEELOJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDealAvatarEventOptionItemCsReq Clone()
	{
		return new PlanetFesDealAvatarEventOptionItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDealAvatarEventOptionItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDealAvatarEventOptionItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ICOGAHFFCLD != other.ICOGAHFFCLD)
		{
			return false;
		}
		if (GLIONEELOJH != other.GLIONEELOJH)
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
		if (ICOGAHFFCLD)
		{
			num ^= ICOGAHFFCLD.GetHashCode();
		}
		if (GLIONEELOJH != 0)
		{
			num ^= GLIONEELOJH.GetHashCode();
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
		if (ICOGAHFFCLD)
		{
			output.WriteRawTag(16);
			output.WriteBool(ICOGAHFFCLD);
		}
		if (GLIONEELOJH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GLIONEELOJH);
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
		if (ICOGAHFFCLD)
		{
			num += 2;
		}
		if (GLIONEELOJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLIONEELOJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesDealAvatarEventOptionItemCsReq other)
	{
		if (other != null)
		{
			if (other.ICOGAHFFCLD)
			{
				ICOGAHFFCLD = other.ICOGAHFFCLD;
			}
			if (other.GLIONEELOJH != 0)
			{
				GLIONEELOJH = other.GLIONEELOJH;
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
				ICOGAHFFCLD = input.ReadBool();
				break;
			case 32u:
				GLIONEELOJH = input.ReadUInt32();
				break;
			}
		}
	}
}
