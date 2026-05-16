using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EvolveBuildStartStageScRsp : IMessage<EvolveBuildStartStageScRsp>, IMessage, IEquatable<EvolveBuildStartStageScRsp>, IDeepCloneable<EvolveBuildStartStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<EvolveBuildStartStageScRsp> _parser = new MessageParser<EvolveBuildStartStageScRsp>(() => new EvolveBuildStartStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MODDIBHCPPDFieldNumber = 5;

	private CJLJDKLCNDA mODDIBHCPPD_;

	public const int DDHGCAFFFOPFieldNumber = 6;

	private SceneBattleInfo dDHGCAFFFOP_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvolveBuildStartStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvolveBuildStartStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJLJDKLCNDA MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo DDHGCAFFFOP
	{
		get
		{
			return dDHGCAFFFOP_;
		}
		set
		{
			dDHGCAFFFOP_ = value;
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
	public EvolveBuildStartStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildStartStageScRsp(EvolveBuildStartStageScRsp other)
		: this()
	{
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		dDHGCAFFFOP_ = ((other.dDHGCAFFFOP_ != null) ? other.dDHGCAFFFOP_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildStartStageScRsp Clone()
	{
		return new EvolveBuildStartStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvolveBuildStartStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvolveBuildStartStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (!object.Equals(DDHGCAFFFOP, other.DDHGCAFFFOP))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (dDHGCAFFFOP_ != null)
		{
			num ^= DDHGCAFFFOP.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (dDHGCAFFFOP_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DDHGCAFFFOP);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
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
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (dDHGCAFFFOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DDHGCAFFFOP);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvolveBuildStartStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new CJLJDKLCNDA();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.dDHGCAFFFOP_ != null)
		{
			if (dDHGCAFFFOP_ == null)
			{
				DDHGCAFFFOP = new SceneBattleInfo();
			}
			DDHGCAFFFOP.MergeFrom(other.DDHGCAFFFOP);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 42u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new CJLJDKLCNDA();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 50u:
				if (dDHGCAFFFOP_ == null)
				{
					DDHGCAFFFOP = new SceneBattleInfo();
				}
				input.ReadMessage(DDHGCAFFFOP);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
