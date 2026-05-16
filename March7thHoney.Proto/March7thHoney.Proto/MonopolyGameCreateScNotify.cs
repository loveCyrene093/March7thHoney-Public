using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGameCreateScNotify : IMessage<MonopolyGameCreateScNotify>, IMessage, IEquatable<MonopolyGameCreateScNotify>, IDeepCloneable<MonopolyGameCreateScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGameCreateScNotify> _parser = new MessageParser<MonopolyGameCreateScNotify>(() => new MonopolyGameCreateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BMKAEFAKNFJFieldNumber = 8;

	private KHCHPPLOFJN bMKAEFAKNFJ_;

	public const int DDLFLPKNLPLFieldNumber = 11;

	private BAFPNCPHNFF dDLFLPKNLPL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGameCreateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGameCreateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN BMKAEFAKNFJ
	{
		get
		{
			return bMKAEFAKNFJ_;
		}
		set
		{
			bMKAEFAKNFJ_ = value;
		}
	}

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
	public MonopolyGameCreateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameCreateScNotify(MonopolyGameCreateScNotify other)
		: this()
	{
		bMKAEFAKNFJ_ = ((other.bMKAEFAKNFJ_ != null) ? other.bMKAEFAKNFJ_.Clone() : null);
		dDLFLPKNLPL_ = ((other.dDLFLPKNLPL_ != null) ? other.dDLFLPKNLPL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameCreateScNotify Clone()
	{
		return new MonopolyGameCreateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGameCreateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGameCreateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BMKAEFAKNFJ, other.BMKAEFAKNFJ))
		{
			return false;
		}
		if (!object.Equals(DDLFLPKNLPL, other.DDLFLPKNLPL))
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
		if (bMKAEFAKNFJ_ != null)
		{
			num ^= BMKAEFAKNFJ.GetHashCode();
		}
		if (dDLFLPKNLPL_ != null)
		{
			num ^= DDLFLPKNLPL.GetHashCode();
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
		if (bMKAEFAKNFJ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BMKAEFAKNFJ);
		}
		if (dDLFLPKNLPL_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DDLFLPKNLPL);
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
		if (bMKAEFAKNFJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKAEFAKNFJ);
		}
		if (dDLFLPKNLPL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DDLFLPKNLPL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGameCreateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bMKAEFAKNFJ_ != null)
		{
			if (bMKAEFAKNFJ_ == null)
			{
				BMKAEFAKNFJ = new KHCHPPLOFJN();
			}
			BMKAEFAKNFJ.MergeFrom(other.BMKAEFAKNFJ);
		}
		if (other.dDLFLPKNLPL_ != null)
		{
			if (dDLFLPKNLPL_ == null)
			{
				DDLFLPKNLPL = new BAFPNCPHNFF();
			}
			DDLFLPKNLPL.MergeFrom(other.DDLFLPKNLPL);
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
			case 66u:
				if (bMKAEFAKNFJ_ == null)
				{
					BMKAEFAKNFJ = new KHCHPPLOFJN();
				}
				input.ReadMessage(BMKAEFAKNFJ);
				break;
			case 90u:
				if (dDLFLPKNLPL_ == null)
				{
					DDLFLPKNLPL = new BAFPNCPHNFF();
				}
				input.ReadMessage(DDLFLPKNLPL);
				break;
			}
		}
	}
}
