using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DNPJOBHHDDH : IMessage<DNPJOBHHDDH>, IMessage, IEquatable<DNPJOBHHDDH>, IDeepCloneable<DNPJOBHHDDH>, IBufferMessage
{
	private static readonly MessageParser<DNPJOBHHDDH> _parser = new MessageParser<DNPJOBHHDDH>(() => new DNPJOBHHDDH());

	private UnknownFieldSet _unknownFields;

	public const int BPBDJPGKEILFieldNumber = 5;

	private uint bPBDJPGKEIL_;

	public const int PDNGPBJEIBJFieldNumber = 8;

	private uint pDNGPBJEIBJ_;

	public const int LOIJLIKOMJNFieldNumber = 13;

	private uint lOIJLIKOMJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DNPJOBHHDDH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DNPJOBHHDDHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPBDJPGKEIL
	{
		get
		{
			return bPBDJPGKEIL_;
		}
		set
		{
			bPBDJPGKEIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDNGPBJEIBJ
	{
		get
		{
			return pDNGPBJEIBJ_;
		}
		set
		{
			pDNGPBJEIBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIJLIKOMJN
	{
		get
		{
			return lOIJLIKOMJN_;
		}
		set
		{
			lOIJLIKOMJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNPJOBHHDDH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNPJOBHHDDH(DNPJOBHHDDH other)
		: this()
	{
		bPBDJPGKEIL_ = other.bPBDJPGKEIL_;
		pDNGPBJEIBJ_ = other.pDNGPBJEIBJ_;
		lOIJLIKOMJN_ = other.lOIJLIKOMJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNPJOBHHDDH Clone()
	{
		return new DNPJOBHHDDH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DNPJOBHHDDH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DNPJOBHHDDH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BPBDJPGKEIL != other.BPBDJPGKEIL)
		{
			return false;
		}
		if (PDNGPBJEIBJ != other.PDNGPBJEIBJ)
		{
			return false;
		}
		if (LOIJLIKOMJN != other.LOIJLIKOMJN)
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
		if (BPBDJPGKEIL != 0)
		{
			num ^= BPBDJPGKEIL.GetHashCode();
		}
		if (PDNGPBJEIBJ != 0)
		{
			num ^= PDNGPBJEIBJ.GetHashCode();
		}
		if (LOIJLIKOMJN != 0)
		{
			num ^= LOIJLIKOMJN.GetHashCode();
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
		if (BPBDJPGKEIL != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BPBDJPGKEIL);
		}
		if (PDNGPBJEIBJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PDNGPBJEIBJ);
		}
		if (LOIJLIKOMJN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LOIJLIKOMJN);
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
		if (BPBDJPGKEIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPBDJPGKEIL);
		}
		if (PDNGPBJEIBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDNGPBJEIBJ);
		}
		if (LOIJLIKOMJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIJLIKOMJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DNPJOBHHDDH other)
	{
		if (other != null)
		{
			if (other.BPBDJPGKEIL != 0)
			{
				BPBDJPGKEIL = other.BPBDJPGKEIL;
			}
			if (other.PDNGPBJEIBJ != 0)
			{
				PDNGPBJEIBJ = other.PDNGPBJEIBJ;
			}
			if (other.LOIJLIKOMJN != 0)
			{
				LOIJLIKOMJN = other.LOIJLIKOMJN;
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
				BPBDJPGKEIL = input.ReadUInt32();
				break;
			case 64u:
				PDNGPBJEIBJ = input.ReadUInt32();
				break;
			case 104u:
				LOIJLIKOMJN = input.ReadUInt32();
				break;
			}
		}
	}
}
