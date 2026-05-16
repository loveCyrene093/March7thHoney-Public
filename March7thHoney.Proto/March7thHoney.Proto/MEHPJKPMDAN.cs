using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEHPJKPMDAN : IMessage<MEHPJKPMDAN>, IMessage, IEquatable<MEHPJKPMDAN>, IDeepCloneable<MEHPJKPMDAN>, IBufferMessage
{
	private static readonly MessageParser<MEHPJKPMDAN> _parser = new MessageParser<MEHPJKPMDAN>(() => new MEHPJKPMDAN());

	private UnknownFieldSet _unknownFields;

	public const int JLBCNLOPLHIFieldNumber = 1;

	private DJMENNMKHLC jLBCNLOPLHI_;

	public const int GBPOPCOKMNMFieldNumber = 2;

	private static readonly FieldCodec<MDDHDNBEELF> _repeated_gBPOPCOKMNM_codec = FieldCodec.ForMessage(18u, MDDHDNBEELF.Parser);

	private readonly RepeatedField<MDDHDNBEELF> gBPOPCOKMNM_ = new RepeatedField<MDDHDNBEELF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEHPJKPMDAN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEHPJKPMDANReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJMENNMKHLC JLBCNLOPLHI
	{
		get
		{
			return jLBCNLOPLHI_;
		}
		set
		{
			jLBCNLOPLHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MDDHDNBEELF> GBPOPCOKMNM => gBPOPCOKMNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHPJKPMDAN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHPJKPMDAN(MEHPJKPMDAN other)
		: this()
	{
		jLBCNLOPLHI_ = ((other.jLBCNLOPLHI_ != null) ? other.jLBCNLOPLHI_.Clone() : null);
		gBPOPCOKMNM_ = other.gBPOPCOKMNM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHPJKPMDAN Clone()
	{
		return new MEHPJKPMDAN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEHPJKPMDAN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEHPJKPMDAN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JLBCNLOPLHI, other.JLBCNLOPLHI))
		{
			return false;
		}
		if (!gBPOPCOKMNM_.Equals(other.gBPOPCOKMNM_))
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
		if (jLBCNLOPLHI_ != null)
		{
			num ^= JLBCNLOPLHI.GetHashCode();
		}
		num ^= gBPOPCOKMNM_.GetHashCode();
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
		if (jLBCNLOPLHI_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JLBCNLOPLHI);
		}
		gBPOPCOKMNM_.WriteTo(ref output, _repeated_gBPOPCOKMNM_codec);
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
		if (jLBCNLOPLHI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JLBCNLOPLHI);
		}
		num += gBPOPCOKMNM_.CalculateSize(_repeated_gBPOPCOKMNM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEHPJKPMDAN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jLBCNLOPLHI_ != null)
		{
			if (jLBCNLOPLHI_ == null)
			{
				JLBCNLOPLHI = new DJMENNMKHLC();
			}
			JLBCNLOPLHI.MergeFrom(other.JLBCNLOPLHI);
		}
		gBPOPCOKMNM_.Add(other.gBPOPCOKMNM_);
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
			case 10u:
				if (jLBCNLOPLHI_ == null)
				{
					JLBCNLOPLHI = new DJMENNMKHLC();
				}
				input.ReadMessage(JLBCNLOPLHI);
				break;
			case 18u:
				gBPOPCOKMNM_.AddEntriesFrom(ref input, _repeated_gBPOPCOKMNM_codec);
				break;
			}
		}
	}
}
