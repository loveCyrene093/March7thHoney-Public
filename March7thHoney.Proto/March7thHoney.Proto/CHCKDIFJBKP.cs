using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CHCKDIFJBKP : IMessage<CHCKDIFJBKP>, IMessage, IEquatable<CHCKDIFJBKP>, IDeepCloneable<CHCKDIFJBKP>, IBufferMessage
{
	private static readonly MessageParser<CHCKDIFJBKP> _parser = new MessageParser<CHCKDIFJBKP>(() => new CHCKDIFJBKP());

	private UnknownFieldSet _unknownFields;

	public const int DNNOFGJJMCPFieldNumber = 10;

	private static readonly FieldCodec<GIGAKCOMKOG> _repeated_dNNOFGJJMCP_codec = FieldCodec.ForMessage(82u, GIGAKCOMKOG.Parser);

	private readonly RepeatedField<GIGAKCOMKOG> dNNOFGJJMCP_ = new RepeatedField<GIGAKCOMKOG>();

	public const int LFBIELBHOBKFieldNumber = 11;

	private uint lFBIELBHOBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CHCKDIFJBKP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CHCKDIFJBKPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GIGAKCOMKOG> DNNOFGJJMCP => dNNOFGJJMCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFBIELBHOBK
	{
		get
		{
			return lFBIELBHOBK_;
		}
		set
		{
			lFBIELBHOBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHCKDIFJBKP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHCKDIFJBKP(CHCKDIFJBKP other)
		: this()
	{
		dNNOFGJJMCP_ = other.dNNOFGJJMCP_.Clone();
		lFBIELBHOBK_ = other.lFBIELBHOBK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHCKDIFJBKP Clone()
	{
		return new CHCKDIFJBKP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CHCKDIFJBKP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CHCKDIFJBKP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dNNOFGJJMCP_.Equals(other.dNNOFGJJMCP_))
		{
			return false;
		}
		if (LFBIELBHOBK != other.LFBIELBHOBK)
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
		num ^= dNNOFGJJMCP_.GetHashCode();
		if (LFBIELBHOBK != 0)
		{
			num ^= LFBIELBHOBK.GetHashCode();
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
		dNNOFGJJMCP_.WriteTo(ref output, _repeated_dNNOFGJJMCP_codec);
		if (LFBIELBHOBK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LFBIELBHOBK);
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
		num += dNNOFGJJMCP_.CalculateSize(_repeated_dNNOFGJJMCP_codec);
		if (LFBIELBHOBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFBIELBHOBK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CHCKDIFJBKP other)
	{
		if (other != null)
		{
			dNNOFGJJMCP_.Add(other.dNNOFGJJMCP_);
			if (other.LFBIELBHOBK != 0)
			{
				LFBIELBHOBK = other.LFBIELBHOBK;
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
			case 82u:
				dNNOFGJJMCP_.AddEntriesFrom(ref input, _repeated_dNNOFGJJMCP_codec);
				break;
			case 88u:
				LFBIELBHOBK = input.ReadUInt32();
				break;
			}
		}
	}
}
