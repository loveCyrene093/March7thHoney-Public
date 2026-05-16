using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJJEHCBNOKI : IMessage<MJJEHCBNOKI>, IMessage, IEquatable<MJJEHCBNOKI>, IDeepCloneable<MJJEHCBNOKI>, IBufferMessage
{
	private static readonly MessageParser<MJJEHCBNOKI> _parser = new MessageParser<MJJEHCBNOKI>(() => new MJJEHCBNOKI());

	private UnknownFieldSet _unknownFields;

	public const int MMKNFIFOPPAFieldNumber = 5;

	private uint mMKNFIFOPPA_;

	public const int FLICPMGFKOKFieldNumber = 13;

	private uint fLICPMGFKOK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJJEHCBNOKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJJEHCBNOKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMKNFIFOPPA
	{
		get
		{
			return mMKNFIFOPPA_;
		}
		set
		{
			mMKNFIFOPPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLICPMGFKOK
	{
		get
		{
			return fLICPMGFKOK_;
		}
		set
		{
			fLICPMGFKOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJJEHCBNOKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJJEHCBNOKI(MJJEHCBNOKI other)
		: this()
	{
		mMKNFIFOPPA_ = other.mMKNFIFOPPA_;
		fLICPMGFKOK_ = other.fLICPMGFKOK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJJEHCBNOKI Clone()
	{
		return new MJJEHCBNOKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJJEHCBNOKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJJEHCBNOKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MMKNFIFOPPA != other.MMKNFIFOPPA)
		{
			return false;
		}
		if (FLICPMGFKOK != other.FLICPMGFKOK)
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
		if (MMKNFIFOPPA != 0)
		{
			num ^= MMKNFIFOPPA.GetHashCode();
		}
		if (FLICPMGFKOK != 0)
		{
			num ^= FLICPMGFKOK.GetHashCode();
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
		if (MMKNFIFOPPA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MMKNFIFOPPA);
		}
		if (FLICPMGFKOK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FLICPMGFKOK);
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
		if (MMKNFIFOPPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMKNFIFOPPA);
		}
		if (FLICPMGFKOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLICPMGFKOK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJJEHCBNOKI other)
	{
		if (other != null)
		{
			if (other.MMKNFIFOPPA != 0)
			{
				MMKNFIFOPPA = other.MMKNFIFOPPA;
			}
			if (other.FLICPMGFKOK != 0)
			{
				FLICPMGFKOK = other.FLICPMGFKOK;
			}
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
			case 40u:
				MMKNFIFOPPA = input.ReadUInt32();
				break;
			case 104u:
				FLICPMGFKOK = input.ReadUInt32();
				break;
			}
		}
	}
}
