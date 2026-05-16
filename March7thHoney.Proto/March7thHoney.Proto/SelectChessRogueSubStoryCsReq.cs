using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectChessRogueSubStoryCsReq : IMessage<SelectChessRogueSubStoryCsReq>, IMessage, IEquatable<SelectChessRogueSubStoryCsReq>, IDeepCloneable<SelectChessRogueSubStoryCsReq>, IBufferMessage
{
	private static readonly MessageParser<SelectChessRogueSubStoryCsReq> _parser = new MessageParser<SelectChessRogueSubStoryCsReq>(() => new SelectChessRogueSubStoryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FOMNFHJCDOCFieldNumber = 3;

	private uint fOMNFHJCDOC_;

	public const int IENBKIAGPBAFieldNumber = 7;

	private uint iENBKIAGPBA_;

	public const int EKEFMNPFOGOFieldNumber = 12;

	private uint eKEFMNPFOGO_;

	public const int RogueDialogueEventIdFieldNumber = 13;

	private uint rogueDialogueEventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectChessRogueSubStoryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public SelectChessRogueSubStoryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChessRogueSubStoryCsReq(SelectChessRogueSubStoryCsReq other)
		: this()
	{
		fOMNFHJCDOC_ = other.fOMNFHJCDOC_;
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		eKEFMNPFOGO_ = other.eKEFMNPFOGO_;
		rogueDialogueEventId_ = other.rogueDialogueEventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChessRogueSubStoryCsReq Clone()
	{
		return new SelectChessRogueSubStoryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectChessRogueSubStoryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectChessRogueSubStoryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FOMNFHJCDOC != other.FOMNFHJCDOC)
		{
			return false;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
		{
			return false;
		}
		if (EKEFMNPFOGO != other.EKEFMNPFOGO)
		{
			return false;
		}
		if (RogueDialogueEventId != other.RogueDialogueEventId)
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
		if (FOMNFHJCDOC != 0)
		{
			num ^= FOMNFHJCDOC.GetHashCode();
		}
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
		}
		if (EKEFMNPFOGO != 0)
		{
			num ^= EKEFMNPFOGO.GetHashCode();
		}
		if (RogueDialogueEventId != 0)
		{
			num ^= RogueDialogueEventId.GetHashCode();
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
		if (FOMNFHJCDOC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FOMNFHJCDOC);
		}
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IENBKIAGPBA);
		}
		if (EKEFMNPFOGO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EKEFMNPFOGO);
		}
		if (RogueDialogueEventId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RogueDialogueEventId);
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
		if (FOMNFHJCDOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOMNFHJCDOC);
		}
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		if (EKEFMNPFOGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKEFMNPFOGO);
		}
		if (RogueDialogueEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueDialogueEventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectChessRogueSubStoryCsReq other)
	{
		if (other != null)
		{
			if (other.FOMNFHJCDOC != 0)
			{
				FOMNFHJCDOC = other.FOMNFHJCDOC;
			}
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
			}
			if (other.EKEFMNPFOGO != 0)
			{
				EKEFMNPFOGO = other.EKEFMNPFOGO;
			}
			if (other.RogueDialogueEventId != 0)
			{
				RogueDialogueEventId = other.RogueDialogueEventId;
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
				FOMNFHJCDOC = input.ReadUInt32();
				break;
			case 56u:
				IENBKIAGPBA = input.ReadUInt32();
				break;
			case 96u:
				EKEFMNPFOGO = input.ReadUInt32();
				break;
			case 104u:
				RogueDialogueEventId = input.ReadUInt32();
				break;
			}
		}
	}
}
