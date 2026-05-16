using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientObjUploadCsReq : IMessage<ClientObjUploadCsReq>, IMessage, IEquatable<ClientObjUploadCsReq>, IDeepCloneable<ClientObjUploadCsReq>, IBufferMessage
{
	private static readonly MessageParser<ClientObjUploadCsReq> _parser = new MessageParser<ClientObjUploadCsReq>(() => new ClientObjUploadCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KKCDCIJHJFAFieldNumber = 2;

	private uint kKCDCIJHJFA_;

	public const int MKHDINDGHMDFieldNumber = 10;

	private NOFMHNNIJAN mKHDINDGHMD_;

	public const int ScDataFieldNumber = 12;

	private ByteString scData_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientObjUploadCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClientObjUploadCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKCDCIJHJFA
	{
		get
		{
			return kKCDCIJHJFA_;
		}
		set
		{
			kKCDCIJHJFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOFMHNNIJAN MKHDINDGHMD
	{
		get
		{
			return mKHDINDGHMD_;
		}
		set
		{
			mKHDINDGHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString ScData
	{
		get
		{
			return scData_;
		}
		set
		{
			scData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjUploadCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjUploadCsReq(ClientObjUploadCsReq other)
		: this()
	{
		kKCDCIJHJFA_ = other.kKCDCIJHJFA_;
		mKHDINDGHMD_ = other.mKHDINDGHMD_;
		scData_ = other.scData_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjUploadCsReq Clone()
	{
		return new ClientObjUploadCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClientObjUploadCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientObjUploadCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKCDCIJHJFA != other.KKCDCIJHJFA)
		{
			return false;
		}
		if (MKHDINDGHMD != other.MKHDINDGHMD)
		{
			return false;
		}
		if (ScData != other.ScData)
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
		if (KKCDCIJHJFA != 0)
		{
			num ^= KKCDCIJHJFA.GetHashCode();
		}
		if (MKHDINDGHMD != NOFMHNNIJAN.Lhbkaepnida)
		{
			num ^= MKHDINDGHMD.GetHashCode();
		}
		if (ScData.Length != 0)
		{
			num ^= ScData.GetHashCode();
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
		if (KKCDCIJHJFA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KKCDCIJHJFA);
		}
		if (MKHDINDGHMD != NOFMHNNIJAN.Lhbkaepnida)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MKHDINDGHMD);
		}
		if (ScData.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteBytes(ScData);
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
		if (KKCDCIJHJFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKCDCIJHJFA);
		}
		if (MKHDINDGHMD != NOFMHNNIJAN.Lhbkaepnida)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MKHDINDGHMD);
		}
		if (ScData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(ScData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientObjUploadCsReq other)
	{
		if (other != null)
		{
			if (other.KKCDCIJHJFA != 0)
			{
				KKCDCIJHJFA = other.KKCDCIJHJFA;
			}
			if (other.MKHDINDGHMD != NOFMHNNIJAN.Lhbkaepnida)
			{
				MKHDINDGHMD = other.MKHDINDGHMD;
			}
			if (other.ScData.Length != 0)
			{
				ScData = other.ScData;
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
			case 16u:
				KKCDCIJHJFA = input.ReadUInt32();
				break;
			case 80u:
				MKHDINDGHMD = (NOFMHNNIJAN)input.ReadEnum();
				break;
			case 98u:
				ScData = input.ReadBytes();
				break;
			}
		}
	}
}
