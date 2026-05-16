using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOKJPHAODDB : IMessage<DOKJPHAODDB>, IMessage, IEquatable<DOKJPHAODDB>, IDeepCloneable<DOKJPHAODDB>, IBufferMessage
{
	private static readonly MessageParser<DOKJPHAODDB> _parser = new MessageParser<DOKJPHAODDB>(() => new DOKJPHAODDB());

	private UnknownFieldSet _unknownFields;

	public const int IGMHPJKAMMBFieldNumber = 3;

	private uint iGMHPJKAMMB_;

	public const int FBIHKFDNJJNFieldNumber = 7;

	private uint fBIHKFDNJJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOKJPHAODDB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOKJPHAODDBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGMHPJKAMMB
	{
		get
		{
			return iGMHPJKAMMB_;
		}
		set
		{
			iGMHPJKAMMB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBIHKFDNJJN
	{
		get
		{
			return fBIHKFDNJJN_;
		}
		set
		{
			fBIHKFDNJJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOKJPHAODDB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOKJPHAODDB(DOKJPHAODDB other)
		: this()
	{
		iGMHPJKAMMB_ = other.iGMHPJKAMMB_;
		fBIHKFDNJJN_ = other.fBIHKFDNJJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOKJPHAODDB Clone()
	{
		return new DOKJPHAODDB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOKJPHAODDB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOKJPHAODDB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGMHPJKAMMB != other.IGMHPJKAMMB)
		{
			return false;
		}
		if (FBIHKFDNJJN != other.FBIHKFDNJJN)
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
		if (IGMHPJKAMMB != 0)
		{
			num ^= IGMHPJKAMMB.GetHashCode();
		}
		if (FBIHKFDNJJN != 0)
		{
			num ^= FBIHKFDNJJN.GetHashCode();
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
		if (IGMHPJKAMMB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IGMHPJKAMMB);
		}
		if (FBIHKFDNJJN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FBIHKFDNJJN);
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
		if (IGMHPJKAMMB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGMHPJKAMMB);
		}
		if (FBIHKFDNJJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBIHKFDNJJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOKJPHAODDB other)
	{
		if (other != null)
		{
			if (other.IGMHPJKAMMB != 0)
			{
				IGMHPJKAMMB = other.IGMHPJKAMMB;
			}
			if (other.FBIHKFDNJJN != 0)
			{
				FBIHKFDNJJN = other.FBIHKFDNJJN;
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
				IGMHPJKAMMB = input.ReadUInt32();
				break;
			case 56u:
				FBIHKFDNJJN = input.ReadUInt32();
				break;
			}
		}
	}
}
