using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LogisticsGameCsReq : IMessage<LogisticsGameCsReq>, IMessage, IEquatable<LogisticsGameCsReq>, IDeepCloneable<LogisticsGameCsReq>, IBufferMessage
{
	private static readonly MessageParser<LogisticsGameCsReq> _parser = new MessageParser<LogisticsGameCsReq>(() => new LogisticsGameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CLPNBFOKJLJFieldNumber = 1;

	private bool cLPNBFOKJLJ_;

	public const int KDKBNMEJLFPFieldNumber = 8;

	private static readonly FieldCodec<CCBKGJGNDCL> _repeated_kDKBNMEJLFP_codec = FieldCodec.ForMessage(66u, CCBKGJGNDCL.Parser);

	private readonly RepeatedField<CCBKGJGNDCL> kDKBNMEJLFP_ = new RepeatedField<CCBKGJGNDCL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LogisticsGameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LogisticsGameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CLPNBFOKJLJ
	{
		get
		{
			return cLPNBFOKJLJ_;
		}
		set
		{
			cLPNBFOKJLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCBKGJGNDCL> KDKBNMEJLFP => kDKBNMEJLFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameCsReq(LogisticsGameCsReq other)
		: this()
	{
		cLPNBFOKJLJ_ = other.cLPNBFOKJLJ_;
		kDKBNMEJLFP_ = other.kDKBNMEJLFP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsGameCsReq Clone()
	{
		return new LogisticsGameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LogisticsGameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LogisticsGameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CLPNBFOKJLJ != other.CLPNBFOKJLJ)
		{
			return false;
		}
		if (!kDKBNMEJLFP_.Equals(other.kDKBNMEJLFP_))
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
		if (CLPNBFOKJLJ)
		{
			num ^= CLPNBFOKJLJ.GetHashCode();
		}
		num ^= kDKBNMEJLFP_.GetHashCode();
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
		if (CLPNBFOKJLJ)
		{
			output.WriteRawTag(8);
			output.WriteBool(CLPNBFOKJLJ);
		}
		kDKBNMEJLFP_.WriteTo(ref output, _repeated_kDKBNMEJLFP_codec);
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
		if (CLPNBFOKJLJ)
		{
			num += 2;
		}
		num += kDKBNMEJLFP_.CalculateSize(_repeated_kDKBNMEJLFP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LogisticsGameCsReq other)
	{
		if (other != null)
		{
			if (other.CLPNBFOKJLJ)
			{
				CLPNBFOKJLJ = other.CLPNBFOKJLJ;
			}
			kDKBNMEJLFP_.Add(other.kDKBNMEJLFP_);
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
			case 8u:
				CLPNBFOKJLJ = input.ReadBool();
				break;
			case 66u:
				kDKBNMEJLFP_.AddEntriesFrom(ref input, _repeated_kDKBNMEJLFP_codec);
				break;
			}
		}
	}
}
