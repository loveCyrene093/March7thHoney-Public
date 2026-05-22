using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KGLOGMHODNB : IMessage<KGLOGMHODNB>, IMessage, IEquatable<KGLOGMHODNB>, IDeepCloneable<KGLOGMHODNB>, IBufferMessage
{
	private static readonly MessageParser<KGLOGMHODNB> _parser = new MessageParser<KGLOGMHODNB>(() => new KGLOGMHODNB());

	private UnknownFieldSet _unknownFields;

	public const int CardIdFieldNumber = 2;

	private uint cardId_;

	public const int HLADJPMDOABFieldNumber = 6;

	private uint hLADJPMDOAB_;

	public const int FAMFCIPLGONFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fAMFCIPLGON_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fAMFCIPLGON_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KGLOGMHODNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KGLOGMHODNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CardId
	{
		get
		{
			return cardId_;
		}
		set
		{
			cardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HLADJPMDOAB
	{
		get
		{
			return hLADJPMDOAB_;
		}
		set
		{
			hLADJPMDOAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FAMFCIPLGON => fAMFCIPLGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGLOGMHODNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGLOGMHODNB(KGLOGMHODNB other)
		: this()
	{
		cardId_ = other.cardId_;
		hLADJPMDOAB_ = other.hLADJPMDOAB_;
		fAMFCIPLGON_ = other.fAMFCIPLGON_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGLOGMHODNB Clone()
	{
		return new KGLOGMHODNB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KGLOGMHODNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KGLOGMHODNB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CardId != other.CardId)
		{
			return false;
		}
		if (HLADJPMDOAB != other.HLADJPMDOAB)
		{
			return false;
		}
		if (!fAMFCIPLGON_.Equals(other.fAMFCIPLGON_))
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
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
		}
		if (HLADJPMDOAB != 0)
		{
			num ^= HLADJPMDOAB.GetHashCode();
		}
		num ^= fAMFCIPLGON_.GetHashCode();
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
		if (CardId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CardId);
		}
		if (HLADJPMDOAB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HLADJPMDOAB);
		}
		fAMFCIPLGON_.WriteTo(ref output, _repeated_fAMFCIPLGON_codec);
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
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CardId);
		}
		if (HLADJPMDOAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HLADJPMDOAB);
		}
		num += fAMFCIPLGON_.CalculateSize(_repeated_fAMFCIPLGON_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KGLOGMHODNB other)
	{
		if (other != null)
		{
			if (other.CardId != 0)
			{
				CardId = other.CardId;
			}
			if (other.HLADJPMDOAB != 0)
			{
				HLADJPMDOAB = other.HLADJPMDOAB;
			}
			fAMFCIPLGON_.Add(other.fAMFCIPLGON_);
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
			case 16u:
				CardId = input.ReadUInt32();
				break;
			case 48u:
				HLADJPMDOAB = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				fAMFCIPLGON_.AddEntriesFrom(ref input, _repeated_fAMFCIPLGON_codec);
				break;
			}
		}
	}
}
