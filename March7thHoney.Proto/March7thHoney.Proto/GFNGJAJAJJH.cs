using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFNGJAJAJJH : IMessage<GFNGJAJAJJH>, IMessage, IEquatable<GFNGJAJAJJH>, IDeepCloneable<GFNGJAJAJJH>, IBufferMessage
{
	private static readonly MessageParser<GFNGJAJAJJH> _parser = new MessageParser<GFNGJAJAJJH>(() => new GFNGJAJAJJH());

	private UnknownFieldSet _unknownFields;

	public const int DDLFLPKNLPLFieldNumber = 1;

	private BAFPNCPHNFF dDLFLPKNLPL_;

	public const int CNJPLPNCMLPFieldNumber = 4;

	private KHCHPPLOFJN cNJPLPNCMLP_;

	public const int NAODINDEKLMFieldNumber = 10;

	private static readonly FieldCodec<KHCHPPLOFJN> _repeated_nAODINDEKLM_codec = FieldCodec.ForMessage(82u, KHCHPPLOFJN.Parser);

	private readonly RepeatedField<KHCHPPLOFJN> nAODINDEKLM_ = new RepeatedField<KHCHPPLOFJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFNGJAJAJJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFNGJAJAJJHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFPNCPHNFF DDLFLPKNLPL
	{
		get
		{
			return dDLFLPKNLPL_;
		}
		set
		{
			dDLFLPKNLPL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN CNJPLPNCMLP
	{
		get
		{
			return cNJPLPNCMLP_;
		}
		set
		{
			cNJPLPNCMLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KHCHPPLOFJN> NAODINDEKLM => nAODINDEKLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNGJAJAJJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNGJAJAJJH(GFNGJAJAJJH other)
		: this()
	{
		dDLFLPKNLPL_ = ((other.dDLFLPKNLPL_ != null) ? other.dDLFLPKNLPL_.Clone() : null);
		cNJPLPNCMLP_ = ((other.cNJPLPNCMLP_ != null) ? other.cNJPLPNCMLP_.Clone() : null);
		nAODINDEKLM_ = other.nAODINDEKLM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNGJAJAJJH Clone()
	{
		return new GFNGJAJAJJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFNGJAJAJJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFNGJAJAJJH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DDLFLPKNLPL, other.DDLFLPKNLPL))
		{
			return false;
		}
		if (!object.Equals(CNJPLPNCMLP, other.CNJPLPNCMLP))
		{
			return false;
		}
		if (!nAODINDEKLM_.Equals(other.nAODINDEKLM_))
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
		if (dDLFLPKNLPL_ != null)
		{
			num ^= DDLFLPKNLPL.GetHashCode();
		}
		if (cNJPLPNCMLP_ != null)
		{
			num ^= CNJPLPNCMLP.GetHashCode();
		}
		num ^= nAODINDEKLM_.GetHashCode();
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
		if (dDLFLPKNLPL_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DDLFLPKNLPL);
		}
		if (cNJPLPNCMLP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CNJPLPNCMLP);
		}
		nAODINDEKLM_.WriteTo(ref output, _repeated_nAODINDEKLM_codec);
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
		if (dDLFLPKNLPL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DDLFLPKNLPL);
		}
		if (cNJPLPNCMLP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CNJPLPNCMLP);
		}
		num += nAODINDEKLM_.CalculateSize(_repeated_nAODINDEKLM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFNGJAJAJJH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dDLFLPKNLPL_ != null)
		{
			if (dDLFLPKNLPL_ == null)
			{
				DDLFLPKNLPL = new BAFPNCPHNFF();
			}
			DDLFLPKNLPL.MergeFrom(other.DDLFLPKNLPL);
		}
		if (other.cNJPLPNCMLP_ != null)
		{
			if (cNJPLPNCMLP_ == null)
			{
				CNJPLPNCMLP = new KHCHPPLOFJN();
			}
			CNJPLPNCMLP.MergeFrom(other.CNJPLPNCMLP);
		}
		nAODINDEKLM_.Add(other.nAODINDEKLM_);
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
				if (dDLFLPKNLPL_ == null)
				{
					DDLFLPKNLPL = new BAFPNCPHNFF();
				}
				input.ReadMessage(DDLFLPKNLPL);
				break;
			case 34u:
				if (cNJPLPNCMLP_ == null)
				{
					CNJPLPNCMLP = new KHCHPPLOFJN();
				}
				input.ReadMessage(CNJPLPNCMLP);
				break;
			case 82u:
				nAODINDEKLM_.AddEntriesFrom(ref input, _repeated_nAODINDEKLM_codec);
				break;
			}
		}
	}
}
