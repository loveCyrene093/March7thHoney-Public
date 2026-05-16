using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnhanceRogueBuffScRsp : IMessage<EnhanceRogueBuffScRsp>, IMessage, IEquatable<EnhanceRogueBuffScRsp>, IDeepCloneable<EnhanceRogueBuffScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnhanceRogueBuffScRsp> _parser = new MessageParser<EnhanceRogueBuffScRsp>(() => new EnhanceRogueBuffScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DAIKNKALKCMFieldNumber = 6;

	private bool dAIKNKALKCM_;

	public const int FGLJOKILKHGFieldNumber = 12;

	private DAGBCJIHJBM fGLJOKILKHG_;

	public const int AGFPFODPOFAFieldNumber = 13;

	private HJGFDIKDIHO aGFPFODPOFA_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnhanceRogueBuffScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnhanceRogueBuffScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DAIKNKALKCM
	{
		get
		{
			return dAIKNKALKCM_;
		}
		set
		{
			dAIKNKALKCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGBCJIHJBM FGLJOKILKHG
	{
		get
		{
			return fGLJOKILKHG_;
		}
		set
		{
			fGLJOKILKHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO AGFPFODPOFA
	{
		get
		{
			return aGFPFODPOFA_;
		}
		set
		{
			aGFPFODPOFA_ = value;
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
	public EnhanceRogueBuffScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnhanceRogueBuffScRsp(EnhanceRogueBuffScRsp other)
		: this()
	{
		dAIKNKALKCM_ = other.dAIKNKALKCM_;
		fGLJOKILKHG_ = ((other.fGLJOKILKHG_ != null) ? other.fGLJOKILKHG_.Clone() : null);
		aGFPFODPOFA_ = ((other.aGFPFODPOFA_ != null) ? other.aGFPFODPOFA_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnhanceRogueBuffScRsp Clone()
	{
		return new EnhanceRogueBuffScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnhanceRogueBuffScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnhanceRogueBuffScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DAIKNKALKCM != other.DAIKNKALKCM)
		{
			return false;
		}
		if (!object.Equals(FGLJOKILKHG, other.FGLJOKILKHG))
		{
			return false;
		}
		if (!object.Equals(AGFPFODPOFA, other.AGFPFODPOFA))
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
		if (DAIKNKALKCM)
		{
			num ^= DAIKNKALKCM.GetHashCode();
		}
		if (fGLJOKILKHG_ != null)
		{
			num ^= FGLJOKILKHG.GetHashCode();
		}
		if (aGFPFODPOFA_ != null)
		{
			num ^= AGFPFODPOFA.GetHashCode();
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
		if (DAIKNKALKCM)
		{
			output.WriteRawTag(48);
			output.WriteBool(DAIKNKALKCM);
		}
		if (fGLJOKILKHG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FGLJOKILKHG);
		}
		if (aGFPFODPOFA_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(AGFPFODPOFA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (DAIKNKALKCM)
		{
			num += 2;
		}
		if (fGLJOKILKHG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FGLJOKILKHG);
		}
		if (aGFPFODPOFA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AGFPFODPOFA);
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
	public void MergeFrom(EnhanceRogueBuffScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DAIKNKALKCM)
		{
			DAIKNKALKCM = other.DAIKNKALKCM;
		}
		if (other.fGLJOKILKHG_ != null)
		{
			if (fGLJOKILKHG_ == null)
			{
				FGLJOKILKHG = new DAGBCJIHJBM();
			}
			FGLJOKILKHG.MergeFrom(other.FGLJOKILKHG);
		}
		if (other.aGFPFODPOFA_ != null)
		{
			if (aGFPFODPOFA_ == null)
			{
				AGFPFODPOFA = new HJGFDIKDIHO();
			}
			AGFPFODPOFA.MergeFrom(other.AGFPFODPOFA);
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
			case 48u:
				DAIKNKALKCM = input.ReadBool();
				break;
			case 98u:
				if (fGLJOKILKHG_ == null)
				{
					FGLJOKILKHG = new DAGBCJIHJBM();
				}
				input.ReadMessage(FGLJOKILKHG);
				break;
			case 106u:
				if (aGFPFODPOFA_ == null)
				{
					AGFPFODPOFA = new HJGFDIKDIHO();
				}
				input.ReadMessage(AGFPFODPOFA);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
