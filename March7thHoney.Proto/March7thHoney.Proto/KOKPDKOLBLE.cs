using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KOKPDKOLBLE : IMessage<KOKPDKOLBLE>, IMessage, IEquatable<KOKPDKOLBLE>, IDeepCloneable<KOKPDKOLBLE>, IBufferMessage
{
	private static readonly MessageParser<KOKPDKOLBLE> _parser = new MessageParser<KOKPDKOLBLE>(() => new KOKPDKOLBLE());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int MNJNFMKIKMHFieldNumber = 15;

	private static readonly FieldCodec<OGJBPHBCMBE> _repeated_mNJNFMKIKMH_codec = FieldCodec.ForMessage(122u, OGJBPHBCMBE.Parser);

	private readonly RepeatedField<OGJBPHBCMBE> mNJNFMKIKMH_ = new RepeatedField<OGJBPHBCMBE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KOKPDKOLBLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KOKPDKOLBLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<OGJBPHBCMBE> MNJNFMKIKMH => mNJNFMKIKMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOKPDKOLBLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOKPDKOLBLE(KOKPDKOLBLE other)
		: this()
	{
		retcode_ = other.retcode_;
		mNJNFMKIKMH_ = other.mNJNFMKIKMH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOKPDKOLBLE Clone()
	{
		return new KOKPDKOLBLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KOKPDKOLBLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KOKPDKOLBLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!mNJNFMKIKMH_.Equals(other.mNJNFMKIKMH_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= mNJNFMKIKMH_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		mNJNFMKIKMH_.WriteTo(ref output, _repeated_mNJNFMKIKMH_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += mNJNFMKIKMH_.CalculateSize(_repeated_mNJNFMKIKMH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KOKPDKOLBLE other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			mNJNFMKIKMH_.Add(other.mNJNFMKIKMH_);
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
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				mNJNFMKIKMH_.AddEntriesFrom(ref input, _repeated_mNJNFMKIKMH_codec);
				break;
			}
		}
	}
}
