using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterEraFlipperDataCsReq : IMessage<EnterEraFlipperDataCsReq>, IMessage, IEquatable<EnterEraFlipperDataCsReq>, IDeepCloneable<EnterEraFlipperDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterEraFlipperDataCsReq> _parser = new MessageParser<EnterEraFlipperDataCsReq>(() => new EnterEraFlipperDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHDLNBPNEKGFieldNumber = 5;

	private uint jHDLNBPNEKG_;

	public const int StateFieldNumber = 6;

	private uint state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterEraFlipperDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterEraFlipperDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHDLNBPNEKG
	{
		get
		{
			return jHDLNBPNEKG_;
		}
		set
		{
			jHDLNBPNEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterEraFlipperDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterEraFlipperDataCsReq(EnterEraFlipperDataCsReq other)
		: this()
	{
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterEraFlipperDataCsReq Clone()
	{
		return new EnterEraFlipperDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterEraFlipperDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterEraFlipperDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (State != other.State)
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
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
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
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JHDLNBPNEKG);
		}
		if (State != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(State);
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
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHDLNBPNEKG);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterEraFlipperDataCsReq other)
	{
		if (other != null)
		{
			if (other.JHDLNBPNEKG != 0)
			{
				JHDLNBPNEKG = other.JHDLNBPNEKG;
			}
			if (other.State != 0)
			{
				State = other.State;
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
				JHDLNBPNEKG = input.ReadUInt32();
				break;
			case 48u:
				State = input.ReadUInt32();
				break;
			}
		}
	}
}
