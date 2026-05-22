using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APKPGIOLLNP : IMessage<APKPGIOLLNP>, IMessage, IEquatable<APKPGIOLLNP>, IDeepCloneable<APKPGIOLLNP>, IBufferMessage
{
	private static readonly MessageParser<APKPGIOLLNP> _parser = new MessageParser<APKPGIOLLNP>(() => new APKPGIOLLNP());

	private UnknownFieldSet _unknownFields;

	public const int FMPNNHDPGKDFieldNumber = 2;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_fMPNNHDPGKD_codec = FieldCodec.ForMessage(18u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> fMPNNHDPGKD_ = new RepeatedField<GKDEKJKOIJN>();

	public const int MEKLIBAPGONFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_mEKLIBAPGON_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> mEKLIBAPGON_ = new RepeatedField<GKDEKJKOIJN>();

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int HEOEKAPBNIEFieldNumber = 13;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_hEOEKAPBNIE_codec = FieldCodec.ForMessage(106u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> hEOEKAPBNIE_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APKPGIOLLNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APKPGIOLLNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> FMPNNHDPGKD => fMPNNHDPGKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> MEKLIBAPGON => mEKLIBAPGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> HEOEKAPBNIE => hEOEKAPBNIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APKPGIOLLNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APKPGIOLLNP(APKPGIOLLNP other)
		: this()
	{
		fMPNNHDPGKD_ = other.fMPNNHDPGKD_.Clone();
		mEKLIBAPGON_ = other.mEKLIBAPGON_.Clone();
		retcode_ = other.retcode_;
		hEOEKAPBNIE_ = other.hEOEKAPBNIE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APKPGIOLLNP Clone()
	{
		return new APKPGIOLLNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APKPGIOLLNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APKPGIOLLNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fMPNNHDPGKD_.Equals(other.fMPNNHDPGKD_))
		{
			return false;
		}
		if (!mEKLIBAPGON_.Equals(other.mEKLIBAPGON_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!hEOEKAPBNIE_.Equals(other.hEOEKAPBNIE_))
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
		num ^= fMPNNHDPGKD_.GetHashCode();
		num ^= mEKLIBAPGON_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= hEOEKAPBNIE_.GetHashCode();
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
		fMPNNHDPGKD_.WriteTo(ref output, _repeated_fMPNNHDPGKD_codec);
		mEKLIBAPGON_.WriteTo(ref output, _repeated_mEKLIBAPGON_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		hEOEKAPBNIE_.WriteTo(ref output, _repeated_hEOEKAPBNIE_codec);
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
		num += fMPNNHDPGKD_.CalculateSize(_repeated_fMPNNHDPGKD_codec);
		num += mEKLIBAPGON_.CalculateSize(_repeated_mEKLIBAPGON_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += hEOEKAPBNIE_.CalculateSize(_repeated_hEOEKAPBNIE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APKPGIOLLNP other)
	{
		if (other != null)
		{
			fMPNNHDPGKD_.Add(other.fMPNNHDPGKD_);
			mEKLIBAPGON_.Add(other.mEKLIBAPGON_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			hEOEKAPBNIE_.Add(other.hEOEKAPBNIE_);
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
				fMPNNHDPGKD_.AddEntriesFrom(ref input, _repeated_fMPNNHDPGKD_codec);
				break;
			case 26u:
				mEKLIBAPGON_.AddEntriesFrom(ref input, _repeated_mEKLIBAPGON_codec);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				hEOEKAPBNIE_.AddEntriesFrom(ref input, _repeated_hEOEKAPBNIE_codec);
				break;
			}
		}
	}
}
