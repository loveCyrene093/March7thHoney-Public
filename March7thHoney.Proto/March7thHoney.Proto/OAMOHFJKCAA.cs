using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OAMOHFJKCAA : IMessage<OAMOHFJKCAA>, IMessage, IEquatable<OAMOHFJKCAA>, IDeepCloneable<OAMOHFJKCAA>, IBufferMessage
{
	private static readonly MessageParser<OAMOHFJKCAA> _parser = new MessageParser<OAMOHFJKCAA>(() => new OAMOHFJKCAA());

	private UnknownFieldSet _unknownFields;

	public const int NKDGKIBEIODFieldNumber = 4;

	private AAGGKGMEKKO nKDGKIBEIOD_;

	public const int EHBKPBOOCHGFieldNumber = 6;

	private static readonly FieldCodec<OBNCGEIIMNB> _repeated_eHBKPBOOCHG_codec = FieldCodec.ForMessage(50u, OBNCGEIIMNB.Parser);

	private readonly RepeatedField<OBNCGEIIMNB> eHBKPBOOCHG_ = new RepeatedField<OBNCGEIIMNB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OAMOHFJKCAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OAMOHFJKCAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAGGKGMEKKO NKDGKIBEIOD
	{
		get
		{
			return nKDGKIBEIOD_;
		}
		set
		{
			nKDGKIBEIOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBNCGEIIMNB> EHBKPBOOCHG => eHBKPBOOCHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMOHFJKCAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMOHFJKCAA(OAMOHFJKCAA other)
		: this()
	{
		nKDGKIBEIOD_ = ((other.nKDGKIBEIOD_ != null) ? other.nKDGKIBEIOD_.Clone() : null);
		eHBKPBOOCHG_ = other.eHBKPBOOCHG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMOHFJKCAA Clone()
	{
		return new OAMOHFJKCAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OAMOHFJKCAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OAMOHFJKCAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NKDGKIBEIOD, other.NKDGKIBEIOD))
		{
			return false;
		}
		if (!eHBKPBOOCHG_.Equals(other.eHBKPBOOCHG_))
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
		if (nKDGKIBEIOD_ != null)
		{
			num ^= NKDGKIBEIOD.GetHashCode();
		}
		num ^= eHBKPBOOCHG_.GetHashCode();
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
		if (nKDGKIBEIOD_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(NKDGKIBEIOD);
		}
		eHBKPBOOCHG_.WriteTo(ref output, _repeated_eHBKPBOOCHG_codec);
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
		if (nKDGKIBEIOD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NKDGKIBEIOD);
		}
		num += eHBKPBOOCHG_.CalculateSize(_repeated_eHBKPBOOCHG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OAMOHFJKCAA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nKDGKIBEIOD_ != null)
		{
			if (nKDGKIBEIOD_ == null)
			{
				NKDGKIBEIOD = new AAGGKGMEKKO();
			}
			NKDGKIBEIOD.MergeFrom(other.NKDGKIBEIOD);
		}
		eHBKPBOOCHG_.Add(other.eHBKPBOOCHG_);
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
				if (nKDGKIBEIOD_ == null)
				{
					NKDGKIBEIOD = new AAGGKGMEKKO();
				}
				input.ReadMessage(NKDGKIBEIOD);
				break;
			case 50u:
				eHBKPBOOCHG_.AddEntriesFrom(ref input, _repeated_eHBKPBOOCHG_codec);
				break;
			}
		}
	}
}
