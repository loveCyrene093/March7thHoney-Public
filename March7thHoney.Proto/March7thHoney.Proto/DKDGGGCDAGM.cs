using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKDGGGCDAGM : IMessage<DKDGGGCDAGM>, IMessage, IEquatable<DKDGGGCDAGM>, IDeepCloneable<DKDGGGCDAGM>, IBufferMessage
{
	private static readonly MessageParser<DKDGGGCDAGM> _parser = new MessageParser<DKDGGGCDAGM>(() => new DKDGGGCDAGM());

	private UnknownFieldSet _unknownFields;

	public const int MNNDMPBFPJEFieldNumber = 5;

	private static readonly FieldCodec<KNCBIMAAFJG> _repeated_mNNDMPBFPJE_codec = FieldCodec.ForMessage(42u, KNCBIMAAFJG.Parser);

	private readonly RepeatedField<KNCBIMAAFJG> mNNDMPBFPJE_ = new RepeatedField<KNCBIMAAFJG>();

	public const int OFFIDMEJBGIFieldNumber = 9;

	private uint oFFIDMEJBGI_;

	public const int MEKLIKLGAFIFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_mEKLIKLGAFI_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> mEKLIKLGAFI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKDGGGCDAGM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKDGGGCDAGMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNCBIMAAFJG> MNNDMPBFPJE => mNNDMPBFPJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFFIDMEJBGI
	{
		get
		{
			return oFFIDMEJBGI_;
		}
		set
		{
			oFFIDMEJBGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEKLIKLGAFI => mEKLIKLGAFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKDGGGCDAGM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKDGGGCDAGM(DKDGGGCDAGM other)
		: this()
	{
		mNNDMPBFPJE_ = other.mNNDMPBFPJE_.Clone();
		oFFIDMEJBGI_ = other.oFFIDMEJBGI_;
		mEKLIKLGAFI_ = other.mEKLIKLGAFI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKDGGGCDAGM Clone()
	{
		return new DKDGGGCDAGM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKDGGGCDAGM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKDGGGCDAGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mNNDMPBFPJE_.Equals(other.mNNDMPBFPJE_))
		{
			return false;
		}
		if (OFFIDMEJBGI != other.OFFIDMEJBGI)
		{
			return false;
		}
		if (!mEKLIKLGAFI_.Equals(other.mEKLIKLGAFI_))
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
		num ^= mNNDMPBFPJE_.GetHashCode();
		if (OFFIDMEJBGI != 0)
		{
			num ^= OFFIDMEJBGI.GetHashCode();
		}
		num ^= mEKLIKLGAFI_.GetHashCode();
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
		mNNDMPBFPJE_.WriteTo(ref output, _repeated_mNNDMPBFPJE_codec);
		if (OFFIDMEJBGI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OFFIDMEJBGI);
		}
		mEKLIKLGAFI_.WriteTo(ref output, _repeated_mEKLIKLGAFI_codec);
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
		num += mNNDMPBFPJE_.CalculateSize(_repeated_mNNDMPBFPJE_codec);
		if (OFFIDMEJBGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFFIDMEJBGI);
		}
		num += mEKLIKLGAFI_.CalculateSize(_repeated_mEKLIKLGAFI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKDGGGCDAGM other)
	{
		if (other != null)
		{
			mNNDMPBFPJE_.Add(other.mNNDMPBFPJE_);
			if (other.OFFIDMEJBGI != 0)
			{
				OFFIDMEJBGI = other.OFFIDMEJBGI;
			}
			mEKLIKLGAFI_.Add(other.mEKLIKLGAFI_);
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
			case 42u:
				mNNDMPBFPJE_.AddEntriesFrom(ref input, _repeated_mNNDMPBFPJE_codec);
				break;
			case 72u:
				OFFIDMEJBGI = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				mEKLIKLGAFI_.AddEntriesFrom(ref input, _repeated_mEKLIKLGAFI_codec);
				break;
			}
		}
	}
}
