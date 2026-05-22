using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FLOEMBHNEPP : IMessage<FLOEMBHNEPP>, IMessage, IEquatable<FLOEMBHNEPP>, IDeepCloneable<FLOEMBHNEPP>, IBufferMessage
{
	private static readonly MessageParser<FLOEMBHNEPP> _parser = new MessageParser<FLOEMBHNEPP>(() => new FLOEMBHNEPP());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int NDKAIAFPNBJFieldNumber = 3;

	private uint nDKAIAFPNBJ_;

	public const int LDKGJBALGKCFieldNumber = 4;

	private uint lDKGJBALGKC_;

	public const int HHHLCANGABLFieldNumber = 5;

	private string hHHLCANGABL_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FLOEMBHNEPP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FLOEMBHNEPPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDKAIAFPNBJ
	{
		get
		{
			return nDKAIAFPNBJ_;
		}
		set
		{
			nDKAIAFPNBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDKGJBALGKC
	{
		get
		{
			return lDKGJBALGKC_;
		}
		set
		{
			lDKGJBALGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HHHLCANGABL
	{
		get
		{
			return hHHLCANGABL_;
		}
		set
		{
			hHHLCANGABL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLOEMBHNEPP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLOEMBHNEPP(FLOEMBHNEPP other)
		: this()
	{
		roomId_ = other.roomId_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		nDKAIAFPNBJ_ = other.nDKAIAFPNBJ_;
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		hHHLCANGABL_ = other.hHHLCANGABL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLOEMBHNEPP Clone()
	{
		return new FLOEMBHNEPP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FLOEMBHNEPP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FLOEMBHNEPP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (NDKAIAFPNBJ != other.NDKAIAFPNBJ)
		{
			return false;
		}
		if (LDKGJBALGKC != other.LDKGJBALGKC)
		{
			return false;
		}
		if (HHHLCANGABL != other.HHHLCANGABL)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (NDKAIAFPNBJ != 0)
		{
			num ^= NDKAIAFPNBJ.GetHashCode();
		}
		if (LDKGJBALGKC != 0)
		{
			num ^= LDKGJBALGKC.GetHashCode();
		}
		if (HHHLCANGABL.Length != 0)
		{
			num ^= HHHLCANGABL.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NDKAIAFPNBJ);
		}
		if (LDKGJBALGKC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LDKGJBALGKC);
		}
		if (HHHLCANGABL.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(HHHLCANGABL);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKAIAFPNBJ);
		}
		if (LDKGJBALGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDKGJBALGKC);
		}
		if (HHHLCANGABL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HHHLCANGABL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FLOEMBHNEPP other)
	{
		if (other != null)
		{
			if (other.RoomId != 0L)
			{
				RoomId = other.RoomId;
			}
			if (other.MMLKFJIAKKH != 0)
			{
				MMLKFJIAKKH = other.MMLKFJIAKKH;
			}
			if (other.NDKAIAFPNBJ != 0)
			{
				NDKAIAFPNBJ = other.NDKAIAFPNBJ;
			}
			if (other.LDKGJBALGKC != 0)
			{
				LDKGJBALGKC = other.LDKGJBALGKC;
			}
			if (other.HHHLCANGABL.Length != 0)
			{
				HHHLCANGABL = other.HHHLCANGABL;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 24u:
				NDKAIAFPNBJ = input.ReadUInt32();
				break;
			case 32u:
				LDKGJBALGKC = input.ReadUInt32();
				break;
			case 42u:
				HHHLCANGABL = input.ReadString();
				break;
			}
		}
	}
}
