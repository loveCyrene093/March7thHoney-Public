using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NILDPLJDLLJ : IMessage<NILDPLJDLLJ>, IMessage, IEquatable<NILDPLJDLLJ>, IDeepCloneable<NILDPLJDLLJ>, IBufferMessage
{
	private static readonly MessageParser<NILDPLJDLLJ> _parser = new MessageParser<NILDPLJDLLJ>(() => new NILDPLJDLLJ());

	private UnknownFieldSet _unknownFields;

	public const int IHALPPAPAHHFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_iHALPPAPAHH_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> iHALPPAPAHH_ = new RepeatedField<uint>();

	public const int FEFBGHPNLFMFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_fEFBGHPNLFM_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> fEFBGHPNLFM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NILDPLJDLLJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NILDPLJDLLJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IHALPPAPAHH => iHALPPAPAHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FEFBGHPNLFM => fEFBGHPNLFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NILDPLJDLLJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NILDPLJDLLJ(NILDPLJDLLJ other)
		: this()
	{
		iHALPPAPAHH_ = other.iHALPPAPAHH_.Clone();
		fEFBGHPNLFM_ = other.fEFBGHPNLFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NILDPLJDLLJ Clone()
	{
		return new NILDPLJDLLJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NILDPLJDLLJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NILDPLJDLLJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iHALPPAPAHH_.Equals(other.iHALPPAPAHH_))
		{
			return false;
		}
		if (!fEFBGHPNLFM_.Equals(other.fEFBGHPNLFM_))
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
		num ^= iHALPPAPAHH_.GetHashCode();
		num ^= fEFBGHPNLFM_.GetHashCode();
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
		iHALPPAPAHH_.WriteTo(ref output, _repeated_iHALPPAPAHH_codec);
		fEFBGHPNLFM_.WriteTo(ref output, _repeated_fEFBGHPNLFM_codec);
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
		num += iHALPPAPAHH_.CalculateSize(_repeated_iHALPPAPAHH_codec);
		num += fEFBGHPNLFM_.CalculateSize(_repeated_fEFBGHPNLFM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NILDPLJDLLJ other)
	{
		if (other != null)
		{
			iHALPPAPAHH_.Add(other.iHALPPAPAHH_);
			fEFBGHPNLFM_.Add(other.fEFBGHPNLFM_);
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
			case 64u:
			case 66u:
				iHALPPAPAHH_.AddEntriesFrom(ref input, _repeated_iHALPPAPAHH_codec);
				break;
			case 120u:
			case 122u:
				fEFBGHPNLFM_.AddEntriesFrom(ref input, _repeated_fEFBGHPNLFM_codec);
				break;
			}
		}
	}
}
