using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JGPAHLMGBML : IMessage<JGPAHLMGBML>, IMessage, IEquatable<JGPAHLMGBML>, IDeepCloneable<JGPAHLMGBML>, IBufferMessage
{
	private static readonly MessageParser<JGPAHLMGBML> _parser = new MessageParser<JGPAHLMGBML>(() => new JGPAHLMGBML());

	private UnknownFieldSet _unknownFields;

	public const int MGNGPGPPIAAFieldNumber = 1;

	private uint mGNGPGPPIAA_;

	public const int ODDFEAEEJJDFieldNumber = 4;

	private uint oDDFEAEEJJD_;

	public const int DKJOOKFCKFNFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dKJOOKFCKFN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dKJOOKFCKFN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JGPAHLMGBML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JGPAHLMGBMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGNGPGPPIAA
	{
		get
		{
			return mGNGPGPPIAA_;
		}
		set
		{
			mGNGPGPPIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODDFEAEEJJD
	{
		get
		{
			return oDDFEAEEJJD_;
		}
		set
		{
			oDDFEAEEJJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DKJOOKFCKFN => dKJOOKFCKFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGPAHLMGBML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGPAHLMGBML(JGPAHLMGBML other)
		: this()
	{
		mGNGPGPPIAA_ = other.mGNGPGPPIAA_;
		oDDFEAEEJJD_ = other.oDDFEAEEJJD_;
		dKJOOKFCKFN_ = other.dKJOOKFCKFN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGPAHLMGBML Clone()
	{
		return new JGPAHLMGBML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JGPAHLMGBML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JGPAHLMGBML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGNGPGPPIAA != other.MGNGPGPPIAA)
		{
			return false;
		}
		if (ODDFEAEEJJD != other.ODDFEAEEJJD)
		{
			return false;
		}
		if (!dKJOOKFCKFN_.Equals(other.dKJOOKFCKFN_))
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
		if (MGNGPGPPIAA != 0)
		{
			num ^= MGNGPGPPIAA.GetHashCode();
		}
		if (ODDFEAEEJJD != 0)
		{
			num ^= ODDFEAEEJJD.GetHashCode();
		}
		num ^= dKJOOKFCKFN_.GetHashCode();
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
		if (MGNGPGPPIAA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MGNGPGPPIAA);
		}
		if (ODDFEAEEJJD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ODDFEAEEJJD);
		}
		dKJOOKFCKFN_.WriteTo(ref output, _repeated_dKJOOKFCKFN_codec);
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
		if (MGNGPGPPIAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGNGPGPPIAA);
		}
		if (ODDFEAEEJJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODDFEAEEJJD);
		}
		num += dKJOOKFCKFN_.CalculateSize(_repeated_dKJOOKFCKFN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JGPAHLMGBML other)
	{
		if (other != null)
		{
			if (other.MGNGPGPPIAA != 0)
			{
				MGNGPGPPIAA = other.MGNGPGPPIAA;
			}
			if (other.ODDFEAEEJJD != 0)
			{
				ODDFEAEEJJD = other.ODDFEAEEJJD;
			}
			dKJOOKFCKFN_.Add(other.dKJOOKFCKFN_);
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
			case 8u:
				MGNGPGPPIAA = input.ReadUInt32();
				break;
			case 32u:
				ODDFEAEEJJD = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				dKJOOKFCKFN_.AddEntriesFrom(ref input, _repeated_dKJOOKFCKFN_codec);
				break;
			}
		}
	}
}
