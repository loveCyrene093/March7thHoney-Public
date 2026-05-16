using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FAEBBLFGAFF : IMessage<FAEBBLFGAFF>, IMessage, IEquatable<FAEBBLFGAFF>, IDeepCloneable<FAEBBLFGAFF>, IBufferMessage
{
	private static readonly MessageParser<FAEBBLFGAFF> _parser = new MessageParser<FAEBBLFGAFF>(() => new FAEBBLFGAFF());

	private UnknownFieldSet _unknownFields;

	public const int MKDNOCJBFBGFieldNumber = 1;

	private uint mKDNOCJBFBG_;

	public const int NPEPBBPMIJHFieldNumber = 2;

	private uint nPEPBBPMIJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FAEBBLFGAFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FAEBBLFGAFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKDNOCJBFBG
	{
		get
		{
			return mKDNOCJBFBG_;
		}
		set
		{
			mKDNOCJBFBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPEPBBPMIJH
	{
		get
		{
			return nPEPBBPMIJH_;
		}
		set
		{
			nPEPBBPMIJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAEBBLFGAFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAEBBLFGAFF(FAEBBLFGAFF other)
		: this()
	{
		mKDNOCJBFBG_ = other.mKDNOCJBFBG_;
		nPEPBBPMIJH_ = other.nPEPBBPMIJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAEBBLFGAFF Clone()
	{
		return new FAEBBLFGAFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FAEBBLFGAFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FAEBBLFGAFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MKDNOCJBFBG != other.MKDNOCJBFBG)
		{
			return false;
		}
		if (NPEPBBPMIJH != other.NPEPBBPMIJH)
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
		if (MKDNOCJBFBG != 0)
		{
			num ^= MKDNOCJBFBG.GetHashCode();
		}
		if (NPEPBBPMIJH != 0)
		{
			num ^= NPEPBBPMIJH.GetHashCode();
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
		if (MKDNOCJBFBG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MKDNOCJBFBG);
		}
		if (NPEPBBPMIJH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NPEPBBPMIJH);
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
		if (MKDNOCJBFBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKDNOCJBFBG);
		}
		if (NPEPBBPMIJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPEPBBPMIJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FAEBBLFGAFF other)
	{
		if (other != null)
		{
			if (other.MKDNOCJBFBG != 0)
			{
				MKDNOCJBFBG = other.MKDNOCJBFBG;
			}
			if (other.NPEPBBPMIJH != 0)
			{
				NPEPBBPMIJH = other.NPEPBBPMIJH;
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
				MKDNOCJBFBG = input.ReadUInt32();
				break;
			case 16u:
				NPEPBBPMIJH = input.ReadUInt32();
				break;
			}
		}
	}
}
