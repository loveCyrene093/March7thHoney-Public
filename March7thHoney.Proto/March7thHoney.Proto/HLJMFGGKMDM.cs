using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLJMFGGKMDM : IMessage<HLJMFGGKMDM>, IMessage, IEquatable<HLJMFGGKMDM>, IDeepCloneable<HLJMFGGKMDM>, IBufferMessage
{
	private static readonly MessageParser<HLJMFGGKMDM> _parser = new MessageParser<HLJMFGGKMDM>(() => new HLJMFGGKMDM());

	private UnknownFieldSet _unknownFields;

	public const int APLGILKDAFJFieldNumber = 8;

	private uint aPLGILKDAFJ_;

	public const int KHCPHHIPOHJFieldNumber = 13;

	private uint kHCPHHIPOHJ_;

	public const int BLBGFIGJBNDFieldNumber = 15;

	private uint bLBGFIGJBND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLJMFGGKMDM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLJMFGGKMDMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APLGILKDAFJ
	{
		get
		{
			return aPLGILKDAFJ_;
		}
		set
		{
			aPLGILKDAFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHCPHHIPOHJ
	{
		get
		{
			return kHCPHHIPOHJ_;
		}
		set
		{
			kHCPHHIPOHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BLBGFIGJBND
	{
		get
		{
			return bLBGFIGJBND_;
		}
		set
		{
			bLBGFIGJBND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLJMFGGKMDM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLJMFGGKMDM(HLJMFGGKMDM other)
		: this()
	{
		aPLGILKDAFJ_ = other.aPLGILKDAFJ_;
		kHCPHHIPOHJ_ = other.kHCPHHIPOHJ_;
		bLBGFIGJBND_ = other.bLBGFIGJBND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLJMFGGKMDM Clone()
	{
		return new HLJMFGGKMDM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLJMFGGKMDM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLJMFGGKMDM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (APLGILKDAFJ != other.APLGILKDAFJ)
		{
			return false;
		}
		if (KHCPHHIPOHJ != other.KHCPHHIPOHJ)
		{
			return false;
		}
		if (BLBGFIGJBND != other.BLBGFIGJBND)
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
		if (APLGILKDAFJ != 0)
		{
			num ^= APLGILKDAFJ.GetHashCode();
		}
		if (KHCPHHIPOHJ != 0)
		{
			num ^= KHCPHHIPOHJ.GetHashCode();
		}
		if (BLBGFIGJBND != 0)
		{
			num ^= BLBGFIGJBND.GetHashCode();
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
		if (APLGILKDAFJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(APLGILKDAFJ);
		}
		if (KHCPHHIPOHJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KHCPHHIPOHJ);
		}
		if (BLBGFIGJBND != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BLBGFIGJBND);
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
		if (APLGILKDAFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APLGILKDAFJ);
		}
		if (KHCPHHIPOHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHCPHHIPOHJ);
		}
		if (BLBGFIGJBND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLBGFIGJBND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLJMFGGKMDM other)
	{
		if (other != null)
		{
			if (other.APLGILKDAFJ != 0)
			{
				APLGILKDAFJ = other.APLGILKDAFJ;
			}
			if (other.KHCPHHIPOHJ != 0)
			{
				KHCPHHIPOHJ = other.KHCPHHIPOHJ;
			}
			if (other.BLBGFIGJBND != 0)
			{
				BLBGFIGJBND = other.BLBGFIGJBND;
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
			case 64u:
				APLGILKDAFJ = input.ReadUInt32();
				break;
			case 104u:
				KHCPHHIPOHJ = input.ReadUInt32();
				break;
			case 120u:
				BLBGFIGJBND = input.ReadUInt32();
				break;
			}
		}
	}
}
