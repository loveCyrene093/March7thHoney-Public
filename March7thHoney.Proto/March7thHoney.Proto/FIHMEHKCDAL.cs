using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIHMEHKCDAL : IMessage<FIHMEHKCDAL>, IMessage, IEquatable<FIHMEHKCDAL>, IDeepCloneable<FIHMEHKCDAL>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None,
		ELAEMOPBDLP,
		GEMABHIPLGB
	}

	private static readonly MessageParser<FIHMEHKCDAL> _parser = new MessageParser<FIHMEHKCDAL>(() => new FIHMEHKCDAL());

	private UnknownFieldSet _unknownFields;

	public const int ELAEMOPBDLPFieldNumber = 1;

	public const int GEMABHIPLGBFieldNumber = 2;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIHMEHKCDAL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIHMEHKCDALReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHPJKPMDAN ELAEMOPBDLP
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ELAEMOPBDLP)
			{
				return null;
			}
			return (MEHPJKPMDAN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ELAEMOPBDLP : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAHIGNNCIA GEMABHIPLGB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.GEMABHIPLGB)
			{
				return null;
			}
			return (BAAHIGNNCIA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.GEMABHIPLGB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIHMEHKCDAL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIHMEHKCDAL(FIHMEHKCDAL other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.ELAEMOPBDLP:
			ELAEMOPBDLP = other.ELAEMOPBDLP.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GEMABHIPLGB:
			GEMABHIPLGB = other.GEMABHIPLGB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIHMEHKCDAL Clone()
	{
		return new FIHMEHKCDAL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIHMEHKCDAL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIHMEHKCDAL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ELAEMOPBDLP, other.ELAEMOPBDLP))
		{
			return false;
		}
		if (!object.Equals(GEMABHIPLGB, other.GEMABHIPLGB))
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ELAEMOPBDLP)
		{
			num ^= ELAEMOPBDLP.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GEMABHIPLGB)
		{
			num ^= GEMABHIPLGB.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ELAEMOPBDLP)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ELAEMOPBDLP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GEMABHIPLGB)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GEMABHIPLGB);
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ELAEMOPBDLP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELAEMOPBDLP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GEMABHIPLGB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GEMABHIPLGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIHMEHKCDAL other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.ELAEMOPBDLP:
			if (ELAEMOPBDLP == null)
			{
				ELAEMOPBDLP = new MEHPJKPMDAN();
			}
			ELAEMOPBDLP.MergeFrom(other.ELAEMOPBDLP);
			break;
		case NLPPPCHGGPFOneofCase.GEMABHIPLGB:
			if (GEMABHIPLGB == null)
			{
				GEMABHIPLGB = new BAAHIGNNCIA();
			}
			GEMABHIPLGB.MergeFrom(other.GEMABHIPLGB);
			break;
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
			case 10u:
			{
				MEHPJKPMDAN mEHPJKPMDAN = new MEHPJKPMDAN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ELAEMOPBDLP)
				{
					mEHPJKPMDAN.MergeFrom(ELAEMOPBDLP);
				}
				input.ReadMessage(mEHPJKPMDAN);
				ELAEMOPBDLP = mEHPJKPMDAN;
				break;
			}
			case 18u:
			{
				BAAHIGNNCIA bAAHIGNNCIA = new BAAHIGNNCIA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GEMABHIPLGB)
				{
					bAAHIGNNCIA.MergeFrom(GEMABHIPLGB);
				}
				input.ReadMessage(bAAHIGNNCIA);
				GEMABHIPLGB = bAAHIGNNCIA;
				break;
			}
			}
		}
	}
}
