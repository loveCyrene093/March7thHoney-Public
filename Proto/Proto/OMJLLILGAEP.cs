using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMJLLILGAEP : IMessage<OMJLLILGAEP>, IMessage, IEquatable<OMJLLILGAEP>, IDeepCloneable<OMJLLILGAEP>, IBufferMessage
{
	private static readonly MessageParser<OMJLLILGAEP> _parser = new MessageParser<OMJLLILGAEP>(() => new OMJLLILGAEP());

	private UnknownFieldSet _unknownFields;

	public const int YFieldNumber = 2;

	private float y_;

	public const int KHAJDKDHPGDFieldNumber = 3;

	private ulong kHAJDKDHPGD_;

	public const int XFieldNumber = 5;

	private float x_;

	public const int KCCFCMAKDLLFieldNumber = 9;

	private float kCCFCMAKDLL_;

	public const int ZFieldNumber = 10;

	private float z_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMJLLILGAEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMJLLILGAEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Y
	{
		get
		{
			return y_;
		}
		set
		{
			y_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KHAJDKDHPGD
	{
		get
		{
			return kHAJDKDHPGD_;
		}
		set
		{
			kHAJDKDHPGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float X
	{
		get
		{
			return x_;
		}
		set
		{
			x_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float KCCFCMAKDLL
	{
		get
		{
			return kCCFCMAKDLL_;
		}
		set
		{
			kCCFCMAKDLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Z
	{
		get
		{
			return z_;
		}
		set
		{
			z_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP(OMJLLILGAEP other)
		: this()
	{
		y_ = other.y_;
		kHAJDKDHPGD_ = other.kHAJDKDHPGD_;
		x_ = other.x_;
		kCCFCMAKDLL_ = other.kCCFCMAKDLL_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP Clone()
	{
		return new OMJLLILGAEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMJLLILGAEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMJLLILGAEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y))
		{
			return false;
		}
		if (KHAJDKDHPGD != other.KHAJDKDHPGD)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KCCFCMAKDLL, other.KCCFCMAKDLL))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z))
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
		if (Y != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
		}
		if (KHAJDKDHPGD != 0L)
		{
			num ^= KHAJDKDHPGD.GetHashCode();
		}
		if (X != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
		}
		if (KCCFCMAKDLL != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KCCFCMAKDLL);
		}
		if (Z != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
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
		if (Y != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Y);
		}
		if (KHAJDKDHPGD != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(KHAJDKDHPGD);
		}
		if (X != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(X);
		}
		if (KCCFCMAKDLL != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(KCCFCMAKDLL);
		}
		if (Z != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(Z);
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
		if (Y != 0f)
		{
			num += 5;
		}
		if (KHAJDKDHPGD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KHAJDKDHPGD);
		}
		if (X != 0f)
		{
			num += 5;
		}
		if (KCCFCMAKDLL != 0f)
		{
			num += 5;
		}
		if (Z != 0f)
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
	public void MergeFrom(OMJLLILGAEP other)
	{
		if (other != null)
		{
			if (other.Y != 0f)
			{
				Y = other.Y;
			}
			if (other.KHAJDKDHPGD != 0L)
			{
				KHAJDKDHPGD = other.KHAJDKDHPGD;
			}
			if (other.X != 0f)
			{
				X = other.X;
			}
			if (other.KCCFCMAKDLL != 0f)
			{
				KCCFCMAKDLL = other.KCCFCMAKDLL;
			}
			if (other.Z != 0f)
			{
				Z = other.Z;
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
			case 21u:
				Y = input.ReadFloat();
				break;
			case 24u:
				KHAJDKDHPGD = input.ReadUInt64();
				break;
			case 45u:
				X = input.ReadFloat();
				break;
			case 77u:
				KCCFCMAKDLL = input.ReadFloat();
				break;
			case 85u:
				Z = input.ReadFloat();
				break;
			}
		}
	}
}
