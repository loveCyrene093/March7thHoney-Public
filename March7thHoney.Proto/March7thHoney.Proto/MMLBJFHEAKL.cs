using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMLBJFHEAKL : IMessage<MMLBJFHEAKL>, IMessage, IEquatable<MMLBJFHEAKL>, IDeepCloneable<MMLBJFHEAKL>, IBufferMessage
{
	private static readonly MessageParser<MMLBJFHEAKL> _parser = new MessageParser<MMLBJFHEAKL>(() => new MMLBJFHEAKL());

	private UnknownFieldSet _unknownFields;

	public const int PanelIdFieldNumber = 1;

	private uint panelId_;

	public const int MKHDINDGHMDFieldNumber = 2;

	private uint mKHDINDGHMD_;

	public const int ENNLJKJGMEIFieldNumber = 3;

	private ulong eNNLJKJGMEI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMLBJFHEAKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMLBJFHEAKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKHDINDGHMD
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
	public ulong ENNLJKJGMEI
	{
		get
		{
			return eNNLJKJGMEI_;
		}
		set
		{
			eNNLJKJGMEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMLBJFHEAKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMLBJFHEAKL(MMLBJFHEAKL other)
		: this()
	{
		panelId_ = other.panelId_;
		mKHDINDGHMD_ = other.mKHDINDGHMD_;
		eNNLJKJGMEI_ = other.eNNLJKJGMEI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMLBJFHEAKL Clone()
	{
		return new MMLBJFHEAKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMLBJFHEAKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMLBJFHEAKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (MKHDINDGHMD != other.MKHDINDGHMD)
		{
			return false;
		}
		if (ENNLJKJGMEI != other.ENNLJKJGMEI)
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
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (MKHDINDGHMD != 0)
		{
			num ^= MKHDINDGHMD.GetHashCode();
		}
		if (ENNLJKJGMEI != 0L)
		{
			num ^= ENNLJKJGMEI.GetHashCode();
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
		if (PanelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PanelId);
		}
		if (MKHDINDGHMD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MKHDINDGHMD);
		}
		if (ENNLJKJGMEI != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(ENNLJKJGMEI);
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
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (MKHDINDGHMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKHDINDGHMD);
		}
		if (ENNLJKJGMEI != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ENNLJKJGMEI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMLBJFHEAKL other)
	{
		if (other != null)
		{
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.MKHDINDGHMD != 0)
			{
				MKHDINDGHMD = other.MKHDINDGHMD;
			}
			if (other.ENNLJKJGMEI != 0L)
			{
				ENNLJKJGMEI = other.ENNLJKJGMEI;
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
				PanelId = input.ReadUInt32();
				break;
			case 16u:
				MKHDINDGHMD = input.ReadUInt32();
				break;
			case 24u:
				ENNLJKJGMEI = input.ReadUInt64();
				break;
			}
		}
	}
}
