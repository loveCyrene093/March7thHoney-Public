using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterSceneCsReq : IMessage<EnterSceneCsReq>, IMessage, IEquatable<EnterSceneCsReq>, IDeepCloneable<EnterSceneCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterSceneCsReq> _parser = new MessageParser<EnterSceneCsReq>(() => new EnterSceneCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsCloseMapFieldNumber = 2;

	private bool isCloseMap_;

	public const int EntryIdFieldNumber = 4;

	private uint entryId_;

	public const int TeleportIdFieldNumber = 6;

	private uint teleportId_;

	public const int OMFKMGKIIKPFieldNumber = 8;

	private bool oMFKMGKIIKP_;

	public const int SceneIdentifierFieldNumber = 9;

	private SceneIdentifier sceneIdentifier_;

	public const int InteractIdFieldNumber = 12;

	private ulong interactId_;

	public const int BLJLBNFPHFEFieldNumber = 13;

	private Vector bLJLBNFPHFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterSceneCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterSceneCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsCloseMap
	{
		get
		{
			return isCloseMap_;
		}
		set
		{
			isCloseMap_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OMFKMGKIIKP
	{
		get
		{
			return oMFKMGKIIKP_;
		}
		set
		{
			oMFKMGKIIKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier SceneIdentifier
	{
		get
		{
			return sceneIdentifier_;
		}
		set
		{
			sceneIdentifier_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector BLJLBNFPHFE
	{
		get
		{
			return bLJLBNFPHFE_;
		}
		set
		{
			bLJLBNFPHFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneCsReq(EnterSceneCsReq other)
		: this()
	{
		isCloseMap_ = other.isCloseMap_;
		entryId_ = other.entryId_;
		teleportId_ = other.teleportId_;
		oMFKMGKIIKP_ = other.oMFKMGKIIKP_;
		sceneIdentifier_ = ((other.sceneIdentifier_ != null) ? other.sceneIdentifier_.Clone() : null);
		interactId_ = other.interactId_;
		bLJLBNFPHFE_ = ((other.bLJLBNFPHFE_ != null) ? other.bLJLBNFPHFE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneCsReq Clone()
	{
		return new EnterSceneCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterSceneCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterSceneCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsCloseMap != other.IsCloseMap)
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (OMFKMGKIIKP != other.OMFKMGKIIKP)
		{
			return false;
		}
		if (!object.Equals(SceneIdentifier, other.SceneIdentifier))
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!object.Equals(BLJLBNFPHFE, other.BLJLBNFPHFE))
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
		if (IsCloseMap)
		{
			num ^= IsCloseMap.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		if (OMFKMGKIIKP)
		{
			num ^= OMFKMGKIIKP.GetHashCode();
		}
		if (sceneIdentifier_ != null)
		{
			num ^= SceneIdentifier.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (bLJLBNFPHFE_ != null)
		{
			num ^= BLJLBNFPHFE.GetHashCode();
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
		if (IsCloseMap)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsCloseMap);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EntryId);
		}
		if (TeleportId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TeleportId);
		}
		if (OMFKMGKIIKP)
		{
			output.WriteRawTag(64);
			output.WriteBool(OMFKMGKIIKP);
		}
		if (sceneIdentifier_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(SceneIdentifier);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(InteractId);
		}
		if (bLJLBNFPHFE_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BLJLBNFPHFE);
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
		if (IsCloseMap)
		{
			num += 2;
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (OMFKMGKIIKP)
		{
			num += 2;
		}
		if (sceneIdentifier_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SceneIdentifier);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (bLJLBNFPHFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLJLBNFPHFE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterSceneCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsCloseMap)
		{
			IsCloseMap = other.IsCloseMap;
		}
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
		}
		if (other.TeleportId != 0)
		{
			TeleportId = other.TeleportId;
		}
		if (other.OMFKMGKIIKP)
		{
			OMFKMGKIIKP = other.OMFKMGKIIKP;
		}
		if (other.sceneIdentifier_ != null)
		{
			if (sceneIdentifier_ == null)
			{
				SceneIdentifier = new SceneIdentifier();
			}
			SceneIdentifier.MergeFrom(other.SceneIdentifier);
		}
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
		}
		if (other.bLJLBNFPHFE_ != null)
		{
			if (bLJLBNFPHFE_ == null)
			{
				BLJLBNFPHFE = new Vector();
			}
			BLJLBNFPHFE.MergeFrom(other.BLJLBNFPHFE);
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
			case 16u:
				IsCloseMap = input.ReadBool();
				break;
			case 32u:
				EntryId = input.ReadUInt32();
				break;
			case 48u:
				TeleportId = input.ReadUInt32();
				break;
			case 64u:
				OMFKMGKIIKP = input.ReadBool();
				break;
			case 74u:
				if (sceneIdentifier_ == null)
				{
					SceneIdentifier = new SceneIdentifier();
				}
				input.ReadMessage(SceneIdentifier);
				break;
			case 96u:
				InteractId = input.ReadUInt64();
				break;
			case 106u:
				if (bLJLBNFPHFE_ == null)
				{
					BLJLBNFPHFE = new Vector();
				}
				input.ReadMessage(BLJLBNFPHFE);
				break;
			}
		}
	}
}
