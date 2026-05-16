using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesBonusEventInteractCsReq : IMessage<PlanetFesBonusEventInteractCsReq>, IMessage, IEquatable<PlanetFesBonusEventInteractCsReq>, IDeepCloneable<PlanetFesBonusEventInteractCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesBonusEventInteractCsReq> _parser = new MessageParser<PlanetFesBonusEventInteractCsReq>(() => new PlanetFesBonusEventInteractCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BFMAOIDEJCDFieldNumber = 5;

	private uint bFMAOIDEJCD_;

	public const int PHKAHAHLDAEFieldNumber = 15;

	private uint pHKAHAHLDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesBonusEventInteractCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesBonusEventInteractCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFMAOIDEJCD
	{
		get
		{
			return bFMAOIDEJCD_;
		}
		set
		{
			bFMAOIDEJCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBonusEventInteractCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBonusEventInteractCsReq(PlanetFesBonusEventInteractCsReq other)
		: this()
	{
		bFMAOIDEJCD_ = other.bFMAOIDEJCD_;
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBonusEventInteractCsReq Clone()
	{
		return new PlanetFesBonusEventInteractCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesBonusEventInteractCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesBonusEventInteractCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFMAOIDEJCD != other.BFMAOIDEJCD)
		{
			return false;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
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
		if (BFMAOIDEJCD != 0)
		{
			num ^= BFMAOIDEJCD.GetHashCode();
		}
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
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
		if (BFMAOIDEJCD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BFMAOIDEJCD);
		}
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PHKAHAHLDAE);
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
		if (BFMAOIDEJCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFMAOIDEJCD);
		}
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesBonusEventInteractCsReq other)
	{
		if (other != null)
		{
			if (other.BFMAOIDEJCD != 0)
			{
				BFMAOIDEJCD = other.BFMAOIDEJCD;
			}
			if (other.PHKAHAHLDAE != 0)
			{
				PHKAHAHLDAE = other.PHKAHAHLDAE;
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
				BFMAOIDEJCD = input.ReadUInt32();
				break;
			case 120u:
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			}
		}
	}
}
