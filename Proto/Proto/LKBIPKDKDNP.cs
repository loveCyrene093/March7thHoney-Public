using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKBIPKDKDNP : IMessage<LKBIPKDKDNP>, IMessage, IEquatable<LKBIPKDKDNP>, IDeepCloneable<LKBIPKDKDNP>, IBufferMessage
{
	private static readonly MessageParser<LKBIPKDKDNP> _parser = new MessageParser<LKBIPKDKDNP>(() => new LKBIPKDKDNP());

	private UnknownFieldSet _unknownFields;

	public const int HNPAHDLKBNPFieldNumber = 3;

	private uint hNPAHDLKBNP_;

	public const int OPAKPBBAPBJFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_oPAKPBBAPBJ_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> oPAKPBBAPBJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKBIPKDKDNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKBIPKDKDNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HNPAHDLKBNP
	{
		get
		{
			return hNPAHDLKBNP_;
		}
		set
		{
			hNPAHDLKBNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OPAKPBBAPBJ => oPAKPBBAPBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBIPKDKDNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBIPKDKDNP(LKBIPKDKDNP other)
		: this()
	{
		hNPAHDLKBNP_ = other.hNPAHDLKBNP_;
		oPAKPBBAPBJ_ = other.oPAKPBBAPBJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBIPKDKDNP Clone()
	{
		return new LKBIPKDKDNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKBIPKDKDNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKBIPKDKDNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HNPAHDLKBNP != other.HNPAHDLKBNP)
		{
			return false;
		}
		if (!oPAKPBBAPBJ_.Equals(other.oPAKPBBAPBJ_))
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
		if (HNPAHDLKBNP != 0)
		{
			num ^= HNPAHDLKBNP.GetHashCode();
		}
		num ^= oPAKPBBAPBJ_.GetHashCode();
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
		if (HNPAHDLKBNP != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HNPAHDLKBNP);
		}
		oPAKPBBAPBJ_.WriteTo(ref output, _repeated_oPAKPBBAPBJ_codec);
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
		if (HNPAHDLKBNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNPAHDLKBNP);
		}
		num += oPAKPBBAPBJ_.CalculateSize(_repeated_oPAKPBBAPBJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LKBIPKDKDNP other)
	{
		if (other != null)
		{
			if (other.HNPAHDLKBNP != 0)
			{
				HNPAHDLKBNP = other.HNPAHDLKBNP;
			}
			oPAKPBBAPBJ_.Add(other.oPAKPBBAPBJ_);
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
			case 24u:
				HNPAHDLKBNP = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				oPAKPBBAPBJ_.AddEntriesFrom(ref input, _repeated_oPAKPBBAPBJ_codec);
				break;
			}
		}
	}
}
