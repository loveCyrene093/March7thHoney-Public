using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTutorialSyncInfo : IMessage<GridFightTutorialSyncInfo>, IMessage, IEquatable<GridFightTutorialSyncInfo>, IDeepCloneable<GridFightTutorialSyncInfo>, IBufferMessage
{
	public enum KCOCCGEOECOOneofCase
	{
		None = 0,
		CurrentTask = 9,
		StartGridFightTutorialId = 10,
		FinishGridFightTutorialId = 11
	}

	private static readonly MessageParser<GridFightTutorialSyncInfo> _parser = new MessageParser<GridFightTutorialSyncInfo>(() => new GridFightTutorialSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int CurrentTaskFieldNumber = 9;

	public const int StartGridFightTutorialIdFieldNumber = 10;

	public const int FinishGridFightTutorialIdFieldNumber = 11;

	private object kCOCCGEOECO_;

	private KCOCCGEOECOOneofCase kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTutorialSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTutorialSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentTask CurrentTask
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.CurrentTask)
			{
				return null;
			}
			return (GridFightCurrentTask)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.CurrentTask : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StartGridFightTutorialId
	{
		get
		{
			if (!HasStartGridFightTutorialId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.StartGridFightTutorialId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStartGridFightTutorialId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.StartGridFightTutorialId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FinishGridFightTutorialId
	{
		get
		{
			if (!HasFinishGridFightTutorialId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.FinishGridFightTutorialId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFinishGridFightTutorialId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FinishGridFightTutorialId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCOCCGEOECOOneofCase KCOCCGEOECOCase => kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTutorialSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTutorialSyncInfo(GridFightTutorialSyncInfo other)
		: this()
	{
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.CurrentTask:
			CurrentTask = other.CurrentTask.Clone();
			break;
		case KCOCCGEOECOOneofCase.StartGridFightTutorialId:
			StartGridFightTutorialId = other.StartGridFightTutorialId;
			break;
		case KCOCCGEOECOOneofCase.FinishGridFightTutorialId:
			FinishGridFightTutorialId = other.FinishGridFightTutorialId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTutorialSyncInfo Clone()
	{
		return new GridFightTutorialSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearStartGridFightTutorialId()
	{
		if (HasStartGridFightTutorialId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFinishGridFightTutorialId()
	{
		if (HasFinishGridFightTutorialId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKCOCCGEOECO()
	{
		kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.None;
		kCOCCGEOECO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTutorialSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTutorialSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CurrentTask, other.CurrentTask))
		{
			return false;
		}
		if (StartGridFightTutorialId != other.StartGridFightTutorialId)
		{
			return false;
		}
		if (FinishGridFightTutorialId != other.FinishGridFightTutorialId)
		{
			return false;
		}
		if (KCOCCGEOECOCase != other.KCOCCGEOECOCase)
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CurrentTask)
		{
			num ^= CurrentTask.GetHashCode();
		}
		if (HasStartGridFightTutorialId)
		{
			num ^= StartGridFightTutorialId.GetHashCode();
		}
		if (HasFinishGridFightTutorialId)
		{
			num ^= FinishGridFightTutorialId.GetHashCode();
		}
		num ^= (int)kCOCCGEOECOCase_;
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CurrentTask)
		{
			output.WriteRawTag(74);
			output.WriteMessage(CurrentTask);
		}
		if (HasStartGridFightTutorialId)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(StartGridFightTutorialId);
		}
		if (HasFinishGridFightTutorialId)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FinishGridFightTutorialId);
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CurrentTask)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurrentTask);
		}
		if (HasStartGridFightTutorialId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StartGridFightTutorialId);
		}
		if (HasFinishGridFightTutorialId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FinishGridFightTutorialId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTutorialSyncInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.CurrentTask:
			if (CurrentTask == null)
			{
				CurrentTask = new GridFightCurrentTask();
			}
			CurrentTask.MergeFrom(other.CurrentTask);
			break;
		case KCOCCGEOECOOneofCase.StartGridFightTutorialId:
			StartGridFightTutorialId = other.StartGridFightTutorialId;
			break;
		case KCOCCGEOECOOneofCase.FinishGridFightTutorialId:
			FinishGridFightTutorialId = other.FinishGridFightTutorialId;
			break;
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
			case 74u:
			{
				GridFightCurrentTask gridFightCurrentTask = new GridFightCurrentTask();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CurrentTask)
				{
					gridFightCurrentTask.MergeFrom(CurrentTask);
				}
				input.ReadMessage(gridFightCurrentTask);
				CurrentTask = gridFightCurrentTask;
				break;
			}
			case 80u:
				StartGridFightTutorialId = input.ReadUInt32();
				break;
			case 88u:
				FinishGridFightTutorialId = input.ReadUInt32();
				break;
			}
		}
	}
}
