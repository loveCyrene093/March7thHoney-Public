using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBECBMMMDHC : IMessage<OBECBMMMDHC>, IMessage, IEquatable<OBECBMMMDHC>, IDeepCloneable<OBECBMMMDHC>, IBufferMessage
{
	private static readonly MessageParser<OBECBMMMDHC> _parser = new MessageParser<OBECBMMMDHC>(() => new OBECBMMMDHC());

	private UnknownFieldSet _unknownFields;

	public const int IMKOJKJAHMMFieldNumber = 2;

	private static readonly FieldCodec<KGLOGMHODNB> _repeated_iMKOJKJAHMM_codec = FieldCodec.ForMessage(18u, KGLOGMHODNB.Parser);

	private readonly RepeatedField<KGLOGMHODNB> iMKOJKJAHMM_ = new RepeatedField<KGLOGMHODNB>();

	public const int FAMFCIPLGONFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fAMFCIPLGON_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fAMFCIPLGON_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBECBMMMDHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBECBMMMDHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KGLOGMHODNB> IMKOJKJAHMM => iMKOJKJAHMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FAMFCIPLGON => fAMFCIPLGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC(OBECBMMMDHC other)
		: this()
	{
		iMKOJKJAHMM_ = other.iMKOJKJAHMM_.Clone();
		fAMFCIPLGON_ = other.fAMFCIPLGON_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC Clone()
	{
		return new OBECBMMMDHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBECBMMMDHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBECBMMMDHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iMKOJKJAHMM_.Equals(other.iMKOJKJAHMM_))
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
		num ^= iMKOJKJAHMM_.GetHashCode();
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
		iMKOJKJAHMM_.WriteTo(ref output, _repeated_iMKOJKJAHMM_codec);
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
		num += iMKOJKJAHMM_.CalculateSize(_repeated_iMKOJKJAHMM_codec);
		num += fAMFCIPLGON_.CalculateSize(_repeated_fAMFCIPLGON_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBECBMMMDHC other)
	{
		if (other != null)
		{
			iMKOJKJAHMM_.Add(other.iMKOJKJAHMM_);
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
			case 18u:
				iMKOJKJAHMM_.AddEntriesFrom(ref input, _repeated_iMKOJKJAHMM_codec);
				break;
			case 56u:
			case 58u:
				fAMFCIPLGON_.AddEntriesFrom(ref input, _repeated_fAMFCIPLGON_codec);
				break;
			}
		}
	}
}
