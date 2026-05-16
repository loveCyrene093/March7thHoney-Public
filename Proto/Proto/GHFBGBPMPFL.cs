using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GHFBGBPMPFL : IMessage<GHFBGBPMPFL>, IMessage, IEquatable<GHFBGBPMPFL>, IDeepCloneable<GHFBGBPMPFL>, IBufferMessage
{
	private static readonly MessageParser<GHFBGBPMPFL> _parser = new MessageParser<GHFBGBPMPFL>(() => new GHFBGBPMPFL());

	private UnknownFieldSet _unknownFields;

	public const int BGBEGBKGBHBFieldNumber = 1;

	private uint bGBEGBKGBHB_;

	public const int IAPFJINFNLOFieldNumber = 11;

	private uint iAPFJINFNLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GHFBGBPMPFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GHFBGBPMPFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGBEGBKGBHB
	{
		get
		{
			return bGBEGBKGBHB_;
		}
		set
		{
			bGBEGBKGBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAPFJINFNLO
	{
		get
		{
			return iAPFJINFNLO_;
		}
		set
		{
			iAPFJINFNLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHFBGBPMPFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHFBGBPMPFL(GHFBGBPMPFL other)
		: this()
	{
		bGBEGBKGBHB_ = other.bGBEGBKGBHB_;
		iAPFJINFNLO_ = other.iAPFJINFNLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHFBGBPMPFL Clone()
	{
		return new GHFBGBPMPFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GHFBGBPMPFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GHFBGBPMPFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BGBEGBKGBHB != other.BGBEGBKGBHB)
		{
			return false;
		}
		if (IAPFJINFNLO != other.IAPFJINFNLO)
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
		if (BGBEGBKGBHB != 0)
		{
			num ^= BGBEGBKGBHB.GetHashCode();
		}
		if (IAPFJINFNLO != 0)
		{
			num ^= IAPFJINFNLO.GetHashCode();
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
		if (BGBEGBKGBHB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BGBEGBKGBHB);
		}
		if (IAPFJINFNLO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IAPFJINFNLO);
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
		if (BGBEGBKGBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGBEGBKGBHB);
		}
		if (IAPFJINFNLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFJINFNLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GHFBGBPMPFL other)
	{
		if (other != null)
		{
			if (other.BGBEGBKGBHB != 0)
			{
				BGBEGBKGBHB = other.BGBEGBKGBHB;
			}
			if (other.IAPFJINFNLO != 0)
			{
				IAPFJINFNLO = other.IAPFJINFNLO;
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
			case 8u:
				BGBEGBKGBHB = input.ReadUInt32();
				break;
			case 88u:
				IAPFJINFNLO = input.ReadUInt32();
				break;
			}
		}
	}
}
