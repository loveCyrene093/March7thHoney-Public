using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JKICLFBINHN : IMessage<JKICLFBINHN>, IMessage, IEquatable<JKICLFBINHN>, IDeepCloneable<JKICLFBINHN>, IBufferMessage
{
	private static readonly MessageParser<JKICLFBINHN> _parser = new MessageParser<JKICLFBINHN>(() => new JKICLFBINHN());

	private UnknownFieldSet _unknownFields;

	public const int BGJKBPNCNLEFieldNumber = 3;

	private int bGJKBPNCNLE_;

	public const int FFBCIEFGLNCFieldNumber = 7;

	private float fFBCIEFGLNC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JKICLFBINHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JKICLFBINHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BGJKBPNCNLE
	{
		get
		{
			return bGJKBPNCNLE_;
		}
		set
		{
			bGJKBPNCNLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float FFBCIEFGLNC
	{
		get
		{
			return fFBCIEFGLNC_;
		}
		set
		{
			fFBCIEFGLNC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKICLFBINHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKICLFBINHN(JKICLFBINHN other)
		: this()
	{
		bGJKBPNCNLE_ = other.bGJKBPNCNLE_;
		fFBCIEFGLNC_ = other.fFBCIEFGLNC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKICLFBINHN Clone()
	{
		return new JKICLFBINHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JKICLFBINHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JKICLFBINHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BGJKBPNCNLE != other.BGJKBPNCNLE)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FFBCIEFGLNC, other.FFBCIEFGLNC))
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
		if (BGJKBPNCNLE != 0)
		{
			num ^= BGJKBPNCNLE.GetHashCode();
		}
		if (FFBCIEFGLNC != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FFBCIEFGLNC);
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
		if (BGJKBPNCNLE != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BGJKBPNCNLE);
		}
		if (FFBCIEFGLNC != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(FFBCIEFGLNC);
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
		if (BGJKBPNCNLE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BGJKBPNCNLE);
		}
		if (FFBCIEFGLNC != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JKICLFBINHN other)
	{
		if (other != null)
		{
			if (other.BGJKBPNCNLE != 0)
			{
				BGJKBPNCNLE = other.BGJKBPNCNLE;
			}
			if (other.FFBCIEFGLNC != 0f)
			{
				FFBCIEFGLNC = other.FFBCIEFGLNC;
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
			case 24u:
				BGJKBPNCNLE = input.ReadInt32();
				break;
			case 61u:
				FFBCIEFGLNC = input.ReadFloat();
				break;
			}
		}
	}
}
