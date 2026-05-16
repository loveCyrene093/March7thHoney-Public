using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMGAOIFBNEO : IMessage<JMGAOIFBNEO>, IMessage, IEquatable<JMGAOIFBNEO>, IDeepCloneable<JMGAOIFBNEO>, IBufferMessage
{
	private static readonly MessageParser<JMGAOIFBNEO> _parser = new MessageParser<JMGAOIFBNEO>(() => new JMGAOIFBNEO());

	private UnknownFieldSet _unknownFields;

	public const int BIEBFHECEPMFieldNumber = 2;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(18u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int DataFieldNumber = 13;

	private LGOPLIAFLCK data_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMGAOIFBNEO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMGAOIFBNEOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

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
	public LGOPLIAFLCK Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMGAOIFBNEO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMGAOIFBNEO(JMGAOIFBNEO other)
		: this()
	{
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		retcode_ = other.retcode_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMGAOIFBNEO Clone()
	{
		return new JMGAOIFBNEO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMGAOIFBNEO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMGAOIFBNEO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
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
		num ^= bIEBFHECEPM_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
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
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (data_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Data);
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
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMGAOIFBNEO other)
	{
		if (other == null)
		{
			return;
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new LGOPLIAFLCK();
			}
			Data.MergeFrom(other.Data);
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
			case 18u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				if (data_ == null)
				{
					Data = new LGOPLIAFLCK();
				}
				input.ReadMessage(Data);
				break;
			}
		}
	}
}
