using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicGetMiscRealTimeDataScRsp : IMessage<RogueMagicGetMiscRealTimeDataScRsp>, IMessage, IEquatable<RogueMagicGetMiscRealTimeDataScRsp>, IDeepCloneable<RogueMagicGetMiscRealTimeDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicGetMiscRealTimeDataScRsp> _parser = new MessageParser<RogueMagicGetMiscRealTimeDataScRsp>(() => new RogueMagicGetMiscRealTimeDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NOCNEOMKFIOFieldNumber = 3;

	private IGJJFOKAHAP nOCNEOMKFIO_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int KKLHGCJKPLJFieldNumber = 9;

	private HHAANBNCLHI kKLHGCJKPLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicGetMiscRealTimeDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGJJFOKAHAP NOCNEOMKFIO
	{
		get
		{
			return nOCNEOMKFIO_;
		}
		set
		{
			nOCNEOMKFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAANBNCLHI KKLHGCJKPLJ
	{
		get
		{
			return kKLHGCJKPLJ_;
		}
		set
		{
			kKLHGCJKPLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicGetMiscRealTimeDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicGetMiscRealTimeDataScRsp(RogueMagicGetMiscRealTimeDataScRsp other)
		: this()
	{
		nOCNEOMKFIO_ = ((other.nOCNEOMKFIO_ != null) ? other.nOCNEOMKFIO_.Clone() : null);
		retcode_ = other.retcode_;
		kKLHGCJKPLJ_ = ((other.kKLHGCJKPLJ_ != null) ? other.kKLHGCJKPLJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicGetMiscRealTimeDataScRsp Clone()
	{
		return new RogueMagicGetMiscRealTimeDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicGetMiscRealTimeDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicGetMiscRealTimeDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NOCNEOMKFIO, other.NOCNEOMKFIO))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(KKLHGCJKPLJ, other.KKLHGCJKPLJ))
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
		if (nOCNEOMKFIO_ != null)
		{
			num ^= NOCNEOMKFIO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (kKLHGCJKPLJ_ != null)
		{
			num ^= KKLHGCJKPLJ.GetHashCode();
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
		if (nOCNEOMKFIO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NOCNEOMKFIO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (kKLHGCJKPLJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(KKLHGCJKPLJ);
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
		if (nOCNEOMKFIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOCNEOMKFIO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (kKLHGCJKPLJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKLHGCJKPLJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicGetMiscRealTimeDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nOCNEOMKFIO_ != null)
		{
			if (nOCNEOMKFIO_ == null)
			{
				NOCNEOMKFIO = new IGJJFOKAHAP();
			}
			NOCNEOMKFIO.MergeFrom(other.NOCNEOMKFIO);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.kKLHGCJKPLJ_ != null)
		{
			if (kKLHGCJKPLJ_ == null)
			{
				KKLHGCJKPLJ = new HHAANBNCLHI();
			}
			KKLHGCJKPLJ.MergeFrom(other.KKLHGCJKPLJ);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 26u:
				if (nOCNEOMKFIO_ == null)
				{
					NOCNEOMKFIO = new IGJJFOKAHAP();
				}
				input.ReadMessage(NOCNEOMKFIO);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (kKLHGCJKPLJ_ == null)
				{
					KKLHGCJKPLJ = new HHAANBNCLHI();
				}
				input.ReadMessage(KKLHGCJKPLJ);
				break;
			}
		}
	}
}
