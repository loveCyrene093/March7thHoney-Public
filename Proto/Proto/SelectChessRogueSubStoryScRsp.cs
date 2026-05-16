using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectChessRogueSubStoryScRsp : IMessage<SelectChessRogueSubStoryScRsp>, IMessage, IEquatable<SelectChessRogueSubStoryScRsp>, IDeepCloneable<SelectChessRogueSubStoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectChessRogueSubStoryScRsp> _parser = new MessageParser<SelectChessRogueSubStoryScRsp>(() => new SelectChessRogueSubStoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IENBKIAGPBAFieldNumber = 6;

	private uint iENBKIAGPBA_;

	public const int RogueDialogueEventIdFieldNumber = 7;

	private uint rogueDialogueEventId_;

	public const int EKEFMNPFOGOFieldNumber = 11;

	private uint eKEFMNPFOGO_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int FOMNFHJCDOCFieldNumber = 14;

	private uint fOMNFHJCDOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectChessRogueSubStoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectChessRogueSubStoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IENBKIAGPBA
	{
		get
		{
			return iENBKIAGPBA_;
		}
		set
		{
			iENBKIAGPBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueDialogueEventId
	{
		get
		{
			return rogueDialogueEventId_;
		}
		set
		{
			rogueDialogueEventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKEFMNPFOGO
	{
		get
		{
			return eKEFMNPFOGO_;
		}
		set
		{
			eKEFMNPFOGO_ = value;
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
	public uint FOMNFHJCDOC
	{
		get
		{
			return fOMNFHJCDOC_;
		}
		set
		{
			fOMNFHJCDOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChessRogueSubStoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChessRogueSubStoryScRsp(SelectChessRogueSubStoryScRsp other)
		: this()
	{
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		rogueDialogueEventId_ = other.rogueDialogueEventId_;
		eKEFMNPFOGO_ = other.eKEFMNPFOGO_;
		retcode_ = other.retcode_;
		fOMNFHJCDOC_ = other.fOMNFHJCDOC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChessRogueSubStoryScRsp Clone()
	{
		return new SelectChessRogueSubStoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectChessRogueSubStoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectChessRogueSubStoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
		{
			return false;
		}
		if (RogueDialogueEventId != other.RogueDialogueEventId)
		{
			return false;
		}
		if (EKEFMNPFOGO != other.EKEFMNPFOGO)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (FOMNFHJCDOC != other.FOMNFHJCDOC)
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
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
		}
		if (RogueDialogueEventId != 0)
		{
			num ^= RogueDialogueEventId.GetHashCode();
		}
		if (EKEFMNPFOGO != 0)
		{
			num ^= EKEFMNPFOGO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (FOMNFHJCDOC != 0)
		{
			num ^= FOMNFHJCDOC.GetHashCode();
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
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IENBKIAGPBA);
		}
		if (RogueDialogueEventId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RogueDialogueEventId);
		}
		if (EKEFMNPFOGO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EKEFMNPFOGO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (FOMNFHJCDOC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FOMNFHJCDOC);
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
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		if (RogueDialogueEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueDialogueEventId);
		}
		if (EKEFMNPFOGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKEFMNPFOGO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (FOMNFHJCDOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOMNFHJCDOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectChessRogueSubStoryScRsp other)
	{
		if (other != null)
		{
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
			}
			if (other.RogueDialogueEventId != 0)
			{
				RogueDialogueEventId = other.RogueDialogueEventId;
			}
			if (other.EKEFMNPFOGO != 0)
			{
				EKEFMNPFOGO = other.EKEFMNPFOGO;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.FOMNFHJCDOC != 0)
			{
				FOMNFHJCDOC = other.FOMNFHJCDOC;
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
			case 48u:
				IENBKIAGPBA = input.ReadUInt32();
				break;
			case 56u:
				RogueDialogueEventId = input.ReadUInt32();
				break;
			case 88u:
				EKEFMNPFOGO = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				FOMNFHJCDOC = input.ReadUInt32();
				break;
			}
		}
	}
}
