using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GOFFLGEJEND : IMessage<GOFFLGEJEND>, IMessage, IEquatable<GOFFLGEJEND>, IDeepCloneable<GOFFLGEJEND>, IBufferMessage
{
	private static readonly MessageParser<GOFFLGEJEND> _parser = new MessageParser<GOFFLGEJEND>(() => new GOFFLGEJEND());

	private UnknownFieldSet _unknownFields;

	public const int JDPHBPHAPKHFieldNumber = 4;

	private uint jDPHBPHAPKH_;

	public const int OCGOCBGLLEIFieldNumber = 13;

	private uint oCGOCBGLLEI_;

	public const int NGBNIPEMHMDFieldNumber = 14;

	private uint nGBNIPEMHMD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GOFFLGEJEND> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GOFFLGEJENDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDPHBPHAPKH
	{
		get
		{
			return jDPHBPHAPKH_;
		}
		set
		{
			jDPHBPHAPKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OCGOCBGLLEI
	{
		get
		{
			return oCGOCBGLLEI_;
		}
		set
		{
			oCGOCBGLLEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGBNIPEMHMD
	{
		get
		{
			return nGBNIPEMHMD_;
		}
		set
		{
			nGBNIPEMHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFLGEJEND()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFLGEJEND(GOFFLGEJEND other)
		: this()
	{
		jDPHBPHAPKH_ = other.jDPHBPHAPKH_;
		oCGOCBGLLEI_ = other.oCGOCBGLLEI_;
		nGBNIPEMHMD_ = other.nGBNIPEMHMD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFLGEJEND Clone()
	{
		return new GOFFLGEJEND(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GOFFLGEJEND);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GOFFLGEJEND other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JDPHBPHAPKH != other.JDPHBPHAPKH)
		{
			return false;
		}
		if (OCGOCBGLLEI != other.OCGOCBGLLEI)
		{
			return false;
		}
		if (NGBNIPEMHMD != other.NGBNIPEMHMD)
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
		if (JDPHBPHAPKH != 0)
		{
			num ^= JDPHBPHAPKH.GetHashCode();
		}
		if (OCGOCBGLLEI != 0)
		{
			num ^= OCGOCBGLLEI.GetHashCode();
		}
		if (NGBNIPEMHMD != 0)
		{
			num ^= NGBNIPEMHMD.GetHashCode();
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
		if (JDPHBPHAPKH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JDPHBPHAPKH);
		}
		if (OCGOCBGLLEI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OCGOCBGLLEI);
		}
		if (NGBNIPEMHMD != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NGBNIPEMHMD);
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
		if (JDPHBPHAPKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDPHBPHAPKH);
		}
		if (OCGOCBGLLEI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OCGOCBGLLEI);
		}
		if (NGBNIPEMHMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGBNIPEMHMD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GOFFLGEJEND other)
	{
		if (other != null)
		{
			if (other.JDPHBPHAPKH != 0)
			{
				JDPHBPHAPKH = other.JDPHBPHAPKH;
			}
			if (other.OCGOCBGLLEI != 0)
			{
				OCGOCBGLLEI = other.OCGOCBGLLEI;
			}
			if (other.NGBNIPEMHMD != 0)
			{
				NGBNIPEMHMD = other.NGBNIPEMHMD;
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
			case 32u:
				JDPHBPHAPKH = input.ReadUInt32();
				break;
			case 104u:
				OCGOCBGLLEI = input.ReadUInt32();
				break;
			case 112u:
				NGBNIPEMHMD = input.ReadUInt32();
				break;
			}
		}
	}
}
