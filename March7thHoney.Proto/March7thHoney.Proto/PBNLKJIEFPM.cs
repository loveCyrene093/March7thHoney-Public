using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PBNLKJIEFPM : IMessage<PBNLKJIEFPM>, IMessage, IEquatable<PBNLKJIEFPM>, IDeepCloneable<PBNLKJIEFPM>, IBufferMessage
{
	private static readonly MessageParser<PBNLKJIEFPM> _parser = new MessageParser<PBNLKJIEFPM>(() => new PBNLKJIEFPM());

	private UnknownFieldSet _unknownFields;

	public const int INFKCHMNNKJFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_iNFKCHMNNKJ_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> iNFKCHMNNKJ_ = new RepeatedField<uint>();

	public const int INAAOHKEOOEFieldNumber = 7;

	private ItemList iNAAOHKEOOE_;

	public const int NOOHOEOCPKEFieldNumber = 14;

	private uint nOOHOEOCPKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PBNLKJIEFPM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PBNLKJIEFPMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> INFKCHMNNKJ => iNFKCHMNNKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList INAAOHKEOOE
	{
		get
		{
			return iNAAOHKEOOE_;
		}
		set
		{
			iNAAOHKEOOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOOHOEOCPKE
	{
		get
		{
			return nOOHOEOCPKE_;
		}
		set
		{
			nOOHOEOCPKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBNLKJIEFPM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBNLKJIEFPM(PBNLKJIEFPM other)
		: this()
	{
		iNFKCHMNNKJ_ = other.iNFKCHMNNKJ_.Clone();
		iNAAOHKEOOE_ = ((other.iNAAOHKEOOE_ != null) ? other.iNAAOHKEOOE_.Clone() : null);
		nOOHOEOCPKE_ = other.nOOHOEOCPKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBNLKJIEFPM Clone()
	{
		return new PBNLKJIEFPM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PBNLKJIEFPM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PBNLKJIEFPM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iNFKCHMNNKJ_.Equals(other.iNFKCHMNNKJ_))
		{
			return false;
		}
		if (!object.Equals(INAAOHKEOOE, other.INAAOHKEOOE))
		{
			return false;
		}
		if (NOOHOEOCPKE != other.NOOHOEOCPKE)
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
		num ^= iNFKCHMNNKJ_.GetHashCode();
		if (iNAAOHKEOOE_ != null)
		{
			num ^= INAAOHKEOOE.GetHashCode();
		}
		if (NOOHOEOCPKE != 0)
		{
			num ^= NOOHOEOCPKE.GetHashCode();
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
		iNFKCHMNNKJ_.WriteTo(ref output, _repeated_iNFKCHMNNKJ_codec);
		if (iNAAOHKEOOE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(INAAOHKEOOE);
		}
		if (NOOHOEOCPKE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NOOHOEOCPKE);
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
		num += iNFKCHMNNKJ_.CalculateSize(_repeated_iNFKCHMNNKJ_codec);
		if (iNAAOHKEOOE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(INAAOHKEOOE);
		}
		if (NOOHOEOCPKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOOHOEOCPKE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PBNLKJIEFPM other)
	{
		if (other == null)
		{
			return;
		}
		iNFKCHMNNKJ_.Add(other.iNFKCHMNNKJ_);
		if (other.iNAAOHKEOOE_ != null)
		{
			if (iNAAOHKEOOE_ == null)
			{
				INAAOHKEOOE = new ItemList();
			}
			INAAOHKEOOE.MergeFrom(other.INAAOHKEOOE);
		}
		if (other.NOOHOEOCPKE != 0)
		{
			NOOHOEOCPKE = other.NOOHOEOCPKE;
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
			case 40u:
			case 42u:
				iNFKCHMNNKJ_.AddEntriesFrom(ref input, _repeated_iNFKCHMNNKJ_codec);
				break;
			case 58u:
				if (iNAAOHKEOOE_ == null)
				{
					INAAOHKEOOE = new ItemList();
				}
				input.ReadMessage(INAAOHKEOOE);
				break;
			case 112u:
				NOOHOEOCPKE = input.ReadUInt32();
				break;
			}
		}
	}
}
