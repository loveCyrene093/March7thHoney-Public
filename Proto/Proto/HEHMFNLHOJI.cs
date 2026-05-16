using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HEHMFNLHOJI : IMessage<HEHMFNLHOJI>, IMessage, IEquatable<HEHMFNLHOJI>, IDeepCloneable<HEHMFNLHOJI>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		COHMGGPHIHN = 4,
		CICGMNHMLME = 11
	}

	private static readonly MessageParser<HEHMFNLHOJI> _parser = new MessageParser<HEHMFNLHOJI>(() => new HEHMFNLHOJI());

	private UnknownFieldSet _unknownFields;

	public const int COHMGGPHIHNFieldNumber = 4;

	public const int CICGMNHMLMEFieldNumber = 11;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HEHMFNLHOJI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HEHMFNLHOJIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMBNFINPHCA COHMGGPHIHN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.COHMGGPHIHN)
			{
				return null;
			}
			return (JMBNFINPHCA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.COHMGGPHIHN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLPGKJLBFLI CICGMNHMLME
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CICGMNHMLME)
			{
				return null;
			}
			return (DLPGKJLBFLI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CICGMNHMLME : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHMFNLHOJI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHMFNLHOJI(HEHMFNLHOJI other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.COHMGGPHIHN:
			COHMGGPHIHN = other.COHMGGPHIHN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CICGMNHMLME:
			CICGMNHMLME = other.CICGMNHMLME.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHMFNLHOJI Clone()
	{
		return new HEHMFNLHOJI(this);
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
		return Equals(other as HEHMFNLHOJI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HEHMFNLHOJI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(COHMGGPHIHN, other.COHMGGPHIHN))
		{
			return false;
		}
		if (!object.Equals(CICGMNHMLME, other.CICGMNHMLME))
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.COHMGGPHIHN)
		{
			num ^= COHMGGPHIHN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CICGMNHMLME)
		{
			num ^= CICGMNHMLME.GetHashCode();
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.COHMGGPHIHN)
		{
			output.WriteRawTag(34);
			output.WriteMessage(COHMGGPHIHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CICGMNHMLME)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CICGMNHMLME);
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.COHMGGPHIHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(COHMGGPHIHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CICGMNHMLME)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CICGMNHMLME);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HEHMFNLHOJI other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.COHMGGPHIHN:
			if (COHMGGPHIHN == null)
			{
				COHMGGPHIHN = new JMBNFINPHCA();
			}
			COHMGGPHIHN.MergeFrom(other.COHMGGPHIHN);
			break;
		case NLPPPCHGGPFOneofCase.CICGMNHMLME:
			if (CICGMNHMLME == null)
			{
				CICGMNHMLME = new DLPGKJLBFLI();
			}
			CICGMNHMLME.MergeFrom(other.CICGMNHMLME);
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
			case 34u:
			{
				JMBNFINPHCA jMBNFINPHCA = new JMBNFINPHCA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.COHMGGPHIHN)
				{
					jMBNFINPHCA.MergeFrom(COHMGGPHIHN);
				}
				input.ReadMessage(jMBNFINPHCA);
				COHMGGPHIHN = jMBNFINPHCA;
				break;
			}
			case 90u:
			{
				DLPGKJLBFLI dLPGKJLBFLI = new DLPGKJLBFLI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CICGMNHMLME)
				{
					dLPGKJLBFLI.MergeFrom(CICGMNHMLME);
				}
				input.ReadMessage(dLPGKJLBFLI);
				CICGMNHMLME = dLPGKJLBFLI;
				break;
			}
			}
		}
	}
}
